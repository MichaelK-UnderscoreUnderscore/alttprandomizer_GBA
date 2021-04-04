using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AlttpRandomizer.IO;
using AlttpRandomizer.Net;
using AlttpRandomizer.Properties;
using AlttpRandomizer.Rom;

namespace AlttpRandomizer.Random
{
    public enum RandomizerDifficulty
	{
        None,
		Casual,
		NoLogic,
	}

	public class Randomizer
	{
		private static SeedRandom random;
		private List<ItemType> haveItems;
		private List<ItemType> itemPool;
		private readonly int seed;
		private readonly IRomLocations romLocations;
		private readonly RandomizerLog log;
		private byte[] romImage;
		private bool romRegion; // US False, JP True

		public Randomizer(byte[] rom, bool region, int seed, IRomLocations romLocations, RandomizerLog log)
		{
			random = new SeedRandom(seed);
			this.romLocations = romLocations;
			this.seed = seed;
			this.log = log;
			romImage = rom;
			romRegion = region;
		}

		public string CreateRom(string filename, bool spoilerOnly = false)
		{
		    try
		    {
                if (filename.Contains("\\") && !Directory.Exists(filename.Substring(0, filename.LastIndexOf('\\'))))
                    Directory.CreateDirectory(filename.Substring(0, filename.LastIndexOf('\\')));

                GenerateItemList();
                GenerateDungeonItems();
                GenerateItemPositions();

		        if (spoilerOnly)
		        {
		            return log?.GetLogOutput();
		        }

                WriteRom(filename);

		        return "";
		    }
            catch (Exception ex)
		    {
                var newEx = new RandomizationException(string.Format("Error creating seed: {0}.", string.Format(romLocations.SeedFileString, seed)), ex);

		        throw newEx;
		    }
		}

		private void GenerateDungeonItems()
		{
			GenerateHyruleCastleEscapeItems();
			GenerateEasternPalaceItems();
			GenerateDesertPalaceItems();
			GenerateTowerOfHeraItems();
			GenerateHyruleCastleTowerItems();
			GenerateDarkPalaceItems();
			GenerateSwampPalaceItems();
			GenerateSkullWoodsItems();
			GenerateThievesTownItems();
			GenerateIcePalaceItems();
			GenerateMiseryMireItems();
			GenerateTurtleRockItems();
			GenerateGanonsTowerItems();
		}

		private void GenerateHyruleCastleEscapeItems()
		{
			var locations = romLocations.Locations.Where(x => x.Region == Region.HyruleCastleEscape).ToList();
			var keys = 2;

			var currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= keys).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Key);
			keys++;

			currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= keys).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Map);
		}

		private void GenerateEasternPalaceItems()
		{
			var locations = romLocations.Locations.Where(x => x.Region == Region.EasternPalace).ToList();

			var currentLocations = locations.Where(x => x.Item == null && !x.BigKeyNeeded).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.BigKey);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Map);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Compass);
		}

		private void GenerateDesertPalaceItems()
		{
			var locations = romLocations.Locations.Where(x => x.Region == Region.DesertPalace).ToList();

			var currentLocations = locations.Where(x => x.Item == null && !x.BigKeyNeeded).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.BigKey);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Map);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Compass);
		}

		private void GenerateTowerOfHeraItems()
		{
			var locations = romLocations.Locations.Where(x => x.Region == Region.TowerOfHera).ToList();

			var currentLocations = locations.Where(x => x.Item == null && !x.BigKeyNeeded).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.BigKey);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Map);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Compass);
		}

		private void GenerateHyruleCastleTowerItems()
		{
			var locations = romLocations.Locations.Where(x => x.Region == Region.HyruleCastleTower).ToList();

			// there are only keys in chests in this dungeon. Boring.
			foreach (var location in locations)
			{
				location.Item = new Item(ItemType.Key);
			}
		}

		private void GenerateDarkPalaceItems()
		{
			var locations = romLocations.Locations.Where(x => x.Region == Region.DarkPalace).ToList();
			var keys = 0;
			List<Location> currentLocations;

            for (int addKeys = 6; addKeys > 0; addKeys--)
            {
                currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= Math.Max(keys - 1, 0)).ToList();
                currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Key);
                keys++;
            }

            currentLocations = locations.Where(x => x.Item == null && !x.BigKeyNeeded).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.BigKey);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Map);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Compass);
		}

		private void GenerateSwampPalaceItems()
		{
			var locations = romLocations.Locations.Where(x => x.Region == Region.SwampPalace).ToList();
			const int keys = 0;

			var currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= keys).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Key);

			currentLocations = locations.Where(x => x.Item == null && !x.BigKeyNeeded).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.BigKey);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Map);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Compass);
		}

		private void GenerateSkullWoodsItems()
		{
			var locations = romLocations.Locations.Where(x => x.Region == Region.SkullWoods).ToList();
			var keys = 2;
			List<Location> currentLocations;

			for (int addKeys = 3; addKeys > 0; addKeys--)
			{
				currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= keys).ToList();
				currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Key);
				keys++;
			}

			currentLocations = locations.Where(x => x.Item == null && !x.BigKeyNeeded).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.BigKey);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Map);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Compass);
		}

		private void GenerateThievesTownItems()
		{
			var locations = romLocations.Locations.Where(x => x.Region == Region.ThievesTown).ToList();

		    var currentLocations = locations.Where(x => x.Item == null && !x.BigKeyNeeded).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.BigKey);

			const int keys = 2;

			currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= Math.Max(keys - 1, 0)).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Key);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Map);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Compass);
		}

		private void GenerateIcePalaceItems()
		{
			var locations = romLocations.Locations.Where(x => x.Region == Region.IcePalace).ToList();
			var keys = 3;
			List<Location> currentLocations;

			for (int addKeys = 2; addKeys > 0; addKeys--)
			{
				currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= keys).ToList();
				currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Key);
				keys++;
			}

			currentLocations = locations.Where(x => x.Item == null && !x.BigKeyNeeded).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.BigKey);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Map);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Compass);
		}

		private void GenerateMiseryMireItems()
		{
			var locations = romLocations.Locations.Where(x => x.Region == Region.MiseryMire).ToList();
			var keys = 1;
			List<Location> currentLocations;

			for (int addKeys = 3; addKeys > 0; addKeys--)
			{
				currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= keys).ToList();
				currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Key);
				keys++;
			}

			currentLocations = locations.Where(x => x.Item == null && !x.BigKeyNeeded).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.BigKey);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Map);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Compass);
		}

		private void GenerateTurtleRockItems()
		{
			var locations = romLocations.Locations.Where(x => x.Region == Region.TurtleRock).ToList();
			var keys = 0;

		    var currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= Math.Max(keys - 1, 0)).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Key);
			keys += 2;

			currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= Math.Max(keys - 1, 0)).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Key);
			keys += 2;

			currentLocations = locations.Where(x => x.Item == null && !x.BigKeyNeeded).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.BigKey);

			for (int addKeys = 2; addKeys > 0; addKeys--)
			{
				currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= Math.Max(keys - 1, 0)).ToList();
				currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Key);
				keys++;
			}

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Map);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Compass);
		}

		private void GenerateGanonsTowerItems()
		{
			var locations = romLocations.Locations.Where(x => x.Region == Region.GanonsTower).ToList();
			var keys = 4;
			List<Location> currentLocations;

			for (int addKeys = 2; addKeys > 0; addKeys--)
			{
				currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= keys && !x.BigKeyNeeded).ToList();
				currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Key);
				keys++;
			}

			currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= keys && !x.BigKeyNeeded).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.BigKey);

			currentLocations = locations.Where(x => x.Item == null && x.KeysNeeded <= keys).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Key);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Map);

			currentLocations = locations.Where(x => x.Item == null).ToList();
			currentLocations[random.Next(currentLocations.Count)].Item = new Item(ItemType.Compass);
		}

		private void WriteRom(string filename)
		{
			string usedFilename = FileName.Fix(filename, string.Format(romLocations.SeedFileString, seed));

			using (var rom = new FileStream(usedFilename, FileMode.OpenOrCreate))
			{
				rom.Write(romImage, 0, 8388608);

				foreach (var location in romLocations.Locations)
				{
					rom.Seek(romRegion ? location.Address_JP : location.Address_US, SeekOrigin.Begin);
				    var newItem = (byte)location.Item.HexValue;

                    rom.Write(new [] { newItem }, 0, 1);

                    location.WriteItemCheck?.Invoke(rom, location.Item.Type, romRegion);
                }

				AddPatches(rom);

				WriteSeedInRom(rom);
				rom.Close();
			}

			log?.WriteLog(usedFilename);
		}

        private void WriteDebugModeToRom(FileStream rom)
        {
			return;
            rom.Seek(0x65b88, SeekOrigin.Begin);
            rom.Write(StringToByteArray("\xea\xea"), 0, 2);
            rom.Seek(0x65b91, SeekOrigin.Begin);
            rom.Write(StringToByteArray("\xea\xea"), 0, 2);
        }

        private void WriteSeedInRom(FileStream rom)
		{
			return;
			string seedStr = string.Format(romLocations.SeedRomString, RandomizerVersion.Current, seed.ToString().PadLeft(7, '0')).PadRight(21).Substring(0, 21);
			rom.Seek(0x7fc0, SeekOrigin.Begin);
			rom.Write(StringToByteArray(seedStr), 0, 21);
		}

		private static byte[] StringToByteArray(string input)
		{
			var retVal = new byte[input.Length];
			var i = 0;

			foreach (var ch in input)
			{
				retVal[i] = (byte)ch;
				i++;
			}

			return retVal;
		}

		private void GenerateItemPositions()
		{
			int count = 0;
			do
			{
				count++;
				try
				{

					var currentLocations = romLocations.GetAvailableLocations(haveItems);
					var tempItems = new List<ItemType>();
					var tempItems2 = new List<ItemType>();

					tempItems.AddRange(itemPool.GetRange(0,itemPool.Count));

					int randItem = random.Next(itemPool.Count < 50 ? itemPool.Count : 50);      // Get a random Item to try and fill next
					var testItem = itemPool[randItem];                                          // Favoring for front of the List where Progression Items are at start.


					if (romLocations.isItemEarly(testItem, itemPool))
					{
						continue;
					}

					tempItems.RemoveAt(randItem);                                               // and remove it from the current test pool

					while (tempItems.Count > tempItems2.Count)                                  // Collect all Items reachable with test Item pool
					{
						tempItems2.Clear();
						tempItems2 = tempItems.ToList();
						var x = romLocations.GetInLogicItems(tempItems);
						tempItems.Clear();
						tempItems = itemPool.ToList();
						tempItems.RemoveAt(randItem);
						tempItems.AddRange(x);
					}

					var locList = romLocations.GetAvailableLocations(tempItems);                // See what Locations are available
					var lateUnique = new List<Location>();
					var loc1 = romLocations.getEmptyLateLocation();
					var loc2 = romLocations.getEmptyUniqueLocation();
					lateUnique.AddRange(loc1);
					lateUnique.AddRange(loc2);

					if (lateUnique.Count > 0)
						locList = lateUnique;
					bool loc = true;
					while (loc)
					{
						int randLT = random.Next(locList.Count);                                // Find a Random Location we can throw our Item in
						if (romLocations.isLocationEarly(locList[randLT]))                      // but first test if the Location is coming to early
							continue;
						if (romLocations.testLocation(testItem, locList[randLT]))
						{
							loc = false;
							foreach (Location location in romLocations.Locations)
								if (location.Name == locList[randLT].Name)
									location.Item = new Item(testItem);
							itemPool.Remove(testItem);
							haveItems.Add(testItem);
						}
					}
				}
				catch (ArgumentOutOfRangeException)
				{
					if (RandomizerVersion.Debug)
					{
						using (var writer = new StreamWriter(string.Format("unavailableLocations - {0}.txt", string.Format(romLocations.SeedFileString, seed))))
						{
							var unavailable = romLocations.GetUnavailableLocations(haveItems);

							writer.WriteLine("Unavailable Locations");
							writer.WriteLine("---------------------");

							foreach (var location in unavailable.OrderBy(x => x.Name))
							{
								writer.WriteLine(location.Name);
							}

							writer.WriteLine();
							writer.WriteLine("Have Items");
							writer.WriteLine("----------");

							foreach (var item in haveItems)
							{
								writer.WriteLine(item);
							}

							writer.WriteLine();
							writer.WriteLine("Item Pool");
							writer.WriteLine("---------");

							foreach (var item in itemPool)
							{
								writer.WriteLine(item);
							}
						}
					}
					throw;
				}
			} while (itemPool.Count > 0);

			foreach (var unavailableLocation in romLocations.getEmptyLocation())
			{
				unavailableLocation.Item = new Item(ItemType.Nothing);
			}

			log?.AddGeneratedItems(romLocations.Locations);
		}

        private List<ItemType> AddProgressionItems(List<ItemType> have)
        {
            var implicitProgressionItems = romLocations.GetImplicitProgressionItems(have);
            var retVal = new List<ItemType>();

            foreach (var item in implicitProgressionItems)
            {
                if (!have.Contains(item))
                {
                    have.Add(item);
                    retVal.Add(item);
                }
            }

            return retVal;
        }

        private void AddPatches(FileStream rom)
        {
			rom.Seek(romRegion ? 0xD34F0 : 0xD2723, SeekOrigin.Begin);
			rom.Write(new[] { (byte)0x01 }, 0, 1);
		}

		private void GenerateItemList()
		{
			romLocations.ResetLocations();
			haveItems = new List<ItemType>();
			itemPool = romLocations.GetItemPool(random);
			var unavailableLocations = romLocations.GetUnavailableLocations(itemPool);

			for (int i = itemPool.Count; i < 100 - unavailableLocations.Count; i++)
			{
				itemPool.Add(ItemType.Nothing);
			}
		}
	}
}
