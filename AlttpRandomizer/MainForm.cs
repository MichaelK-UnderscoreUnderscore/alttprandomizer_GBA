using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlttpRandomizer.IO;
using AlttpRandomizer.Net;
using AlttpRandomizer.Properties;
using AlttpRandomizer.Random;
using AlttpRandomizer.Rom;
using CRC;


namespace AlttpRandomizer
{
    public partial class MainForm : Form
    {
		private Thread checkUpdateThread;
        private byte[] romImage;
        private bool romRegion; // US False, JP True


        public MainForm()
        {
			InitializeSettings();
			InitializeComponent();
		}

		private void InitializeSettings()
		{
			// this fixes an issue with running on mono
			Settings.Default.OutputFile = Settings.Default.OutputFile;
			Settings.Default.RandomizerDifficulty = Settings.Default.RandomizerDifficulty;
			Settings.Default.CreateSpoilerLog = Settings.Default.CreateSpoilerLog;
		}

		private void create_Click(object sender, EventArgs e)
        {
            ClearOutput();

            if (string.IsNullOrWhiteSpace(seed.Text))
			{
				SetSeedBasedOnDifficulty();
			}

		    var difficulty = GetRandomizerDifficulty();

		    if (difficulty == RandomizerDifficulty.None)
		    {
		        return;
		    }

            CreateRom(difficulty);

		    Settings.Default.CreateSpoilerLog = createSpoilerLog.Checked;
			Settings.Default.RandomizerDifficulty = randomizerDifficulty.SelectedItem.ToString();
			Settings.Default.Save();
		}

        private void CreateRom(RandomizerDifficulty difficulty)
        {
            int parsedSeed;
            string y = Regex.Replace(seed.Text, @"\D", "");
            if (!int.TryParse(y, out parsedSeed))
            {
                MessageBox.Show("Seed must be numeric or blank.", "Seed Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WriteOutput("Seed must be numeric or blank.");
            }
            else
            {
                var romPlms = RomLocationsFactory.GetRomPlms(difficulty);
                RandomizerLog log = null;

                if (createSpoilerLog.Checked)
                {
                    log = new RandomizerLog(string.Format(romPlms.SeedFileString, parsedSeed));
                }

                seed.Text = string.Format(romPlms.SeedFileString, parsedSeed);

                try
                {
                    var randomizer = new Randomizer(romImage, romRegion, parsedSeed, romPlms, log); ;
                    randomizer.CreateRom(filename.Text);

                    var outputString = new StringBuilder();

                    outputString.AppendFormat("Done!{0}{0}{0}Seed: ", Environment.NewLine);
                    outputString.AppendFormat(romPlms.SeedFileString, parsedSeed);
                    outputString.AppendFormat(" ({0} Difficulty){1}{1}", romPlms.DifficultyName, Environment.NewLine);

                    WriteOutput(outputString.ToString());
                }
                catch (RandomizationException ex)
                {
                    WriteOutput(ex.ToString());
                }
            }
        }

        private void CreateSpoilerLog(RandomizerDifficulty difficulty)
        {
            int parsedSeed;

            if (!int.TryParse(seed.Text, out parsedSeed))
            {
                MessageBox.Show("Seed must be numeric or blank.", "Seed Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WriteOutput("Seed must be numeric or blank.");
            }
            else
            {
                var romPlms = RomLocationsFactory.GetRomPlms(difficulty);
                RandomizerLog log = new RandomizerLog(string.Format(romPlms.SeedFileString, parsedSeed));

                seed.Text = string.Format(romPlms.SeedFileString, parsedSeed);

                try
                {
                    var randomizer = new Randomizer(romImage, romRegion, parsedSeed, romPlms, log);
                    WriteOutput(randomizer.CreateRom(filename.Text, true));
                }
                catch (RandomizationException ex)
                {
                    WriteOutput(ex.ToString());
                }
            }
        }


        private RandomizerDifficulty GetRandomizerDifficulty()
        {
            RandomizerDifficulty difficulty;

            if (seed.Text.ElementAt(0) == 'C')
                randomizerDifficulty.SelectedIndex = 0;
            else if(seed.Text.ElementAt(0) == 'N' && seed.Text.ElementAt(1) == 'L')
                randomizerDifficulty.SelectedIndex = 1;

            switch (randomizerDifficulty.SelectedItem.ToString())
            {
                case "Casual":
                    difficulty = RandomizerDifficulty.Casual;
                    break;
                case "No Logic":
                    difficulty = RandomizerDifficulty.NoLogic;
                    break;
                default:
                    MessageBox.Show("Please select a difficulty.", "Select Difficulty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    WriteOutput("Please select a difficulty.");
                    return RandomizerDifficulty.None;
            }
            return difficulty;
        }

        private void SetSeedBasedOnDifficulty()
        {
            switch (randomizerDifficulty.SelectedItem.ToString())
            {
                default:
                    seed.Text = string.Format("{0:0000000}", (new SeedRandom()).Next(10000000));
                    break;
            }
        }

        private void ClearOutput()
		{
			output.Text = "";
		}

		private void WriteOutput(string text)
		{
			output.Text += text;
		}

		private void browse_Click(object sender, EventArgs e)
		{
			var info = new FileInfo(Regex.Replace(filename.Text, "<.*>", ""));
			var saveFileDialog = new SaveFileDialog { Filter = "All files (*.*)|*.*", FilterIndex = 2, RestoreDirectory = true, InitialDirectory = info.DirectoryName, FileName = info.Name };

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				filename.Text = saveFileDialog.FileName;
				MessageBox.Show("Remember to hit \"create\" to create the rom.", "Remember to create the rom!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
			}
		}

		private void filename_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.OutputFile = filename.Text;
			Settings.Default.Save();
		}

		private void filename_Leave(object sender, EventArgs e)
		{
			var senderText = (TextBox)sender;

			if (!senderText.Text.Contains("."))
			{
				senderText.Text += ".gba";
			}
		}

		private void btnReport_Click(object sender, EventArgs e)
		{
            Help.ShowHelp(null, string.Format("https://github.com/MichaelK-UnderscoreUnderscore/alttprandomizer_GBA/issues"));
        }

		private void MainForm_Load(object sender, EventArgs e)
		{
			filename.Text = Settings.Default.OutputFile;
			createSpoilerLog.Checked = Settings.Default.CreateSpoilerLog;
			Text = string.Format("A Link to the Past GBA Randomizer v{0}", RandomizerVersion.CurrentDisplay);
			randomizerDifficulty.SelectedItem = Settings.Default.RandomizerDifficulty;
			RunCheckUpdate();

            if (RandomizerVersion.Debug)
            {
                create.BackColor = Color.DarkRed;
                Text += " *** DEBUG ***";
            }
        }

        private void RunCheckUpdate()
		{
            return;
			checkUpdateThread = new Thread(RandomizerVersion.CheckUpdate);
			checkUpdateThread.SetApartmentState(ApartmentState.STA);
			checkUpdateThread.Start();
		}

        private void randomSpoiler_Click(object sender, EventArgs e)
        {
            SetSeedBasedOnDifficulty();

            ClearOutput();

            var difficulty = GetRandomizerDifficulty();
            CreateSpoilerLog(difficulty);
        }

        private void selrom_Click(object sender, EventArgs e)
        {
            ClearOutput();

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "GBA Roms(*.gba)|*.gba|All Files|*.*";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.ShowDialog();
                byte[] rom = File.ReadAllBytes(openFileDialog.FileName);
                string hash = Crc32.ToHexString(rom);

                switch (hash)
                {
                    case "8E91CD13":
                        output.Text = hash + Environment.NewLine +
                            "American Release";
                        romRegion = false;
                        romImage = rom;
                        create.Enabled = true;
                        break;
                    case "81E42BEE":
                        output.Text = hash + Environment.NewLine +
                            "Japanese Release" + Environment.NewLine +
                            "This Version will work in current and near future Versions," + Environment.NewLine +
                            "but will eventually be removed in favor of focusing on the US release.";
                        romRegion = true;
                        romImage = rom;
                        create.Enabled = true;
                        break;
                    case "5A164321 ":
                        output.Text = hash + Environment.NewLine +
                            "This is the PAL release of the Game and not supported in this randomizer." + Environment.NewLine +
                            "Please use a Rom with either \"8E91CD13\" (US) or \"81E42BEE\" as CRC32 Hash.";
                        break;
                    default:
                        output.Text = hash + Environment.NewLine +
                            "The Hash was not of the US or JP Rom supported in this." + Environment.NewLine +
                            "Please use a Rom with either \"8E91CD13\" (US) or \"81E42BEE\" as CRC32 Hash.";
                        break;
                }

            } catch (Exception f)
            {
                output.Text = f.ToString();
            }
        }
    }
}
