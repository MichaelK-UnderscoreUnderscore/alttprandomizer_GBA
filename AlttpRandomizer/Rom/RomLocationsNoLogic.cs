using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlttpRandomizer.Random;
using AlttpRandomizer.Rom;

namespace AlttpRandomizer.Rom
{
    public class RomLocationsNoLogic : IRomLocations
    {
        public List<Location> Locations { get; set; }
        public string DifficultyName => "NoLogic";
        public string SeedFileString => "NL{0:0000000}";
        public string SeedRomString => "Z3Rv{0} NoLogic{1}";

        public void ResetLocations()
        {
            Locations = new List<Location>
            {
                new Location
                {
                    LateGameItem = false,
                    Region = Region.HyruleCastleEscape,
                    Name = "[dungeon-C-B1] Escape - first B1 room",
                    Address = 0x154664,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-034] Hyrule Castle secret entrance",
                    Address = 0x154667,
                    CanAccess =
                        have =>
                        true,
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.HyruleCastleEscape,
                    Name = "[dungeon-C-B1] Hyrule Castle - boomerang room",
                    Address = 0x15466A,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        true,
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.EasternPalace,
                    Name = "[dungeon-L1-1F] Eastern Palace - compass room",
                    Address = 0x15466D,
                    CanAccess =
                        have =>
                        CanEnterEasternPalace(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-018] Graveyard - top right grave",
                    Address = 0x154670,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.EasternPalace,
                    Name = "[dungeon-L1-1F] Eastern Palace - big chest",
                    Address = 0x154673,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SwampPalace,
                    Name = "[dungeon-D2-B1] Swamp Palace - map room",
                    Address = 0x15467C,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SwampPalace,
                    Name = "[dungeon-D2-B1] Swamp Palace - big chest",
                    Address = 0x15467F,
                    KeysNeeded = 3,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-047] Dam",
                    Address = 0x154682,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.DesertPalace,
                    Name = "[dungeon-L2-B1] Desert Palace - big chest",
                    Address = 0x154685,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SkullWoods,
                    Name = "[dungeon-D3-B1] Skull Woods - Compass room",
                    Address = 0x154688,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.IcePalace,
                    Name = "[dungeon-D5-B4] Ice Palace - above Blue Mail room",
                    Address = 0x15468B,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SkullWoods,
                    Name = "[dungeon-D3-B1] Skull Woods - big chest",
                    Address = 0x15468E,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SkullWoods,
                    Name = "[dungeon-D3-B1] Skull Woods - east of Fire Rod room",
                    Address = 0x154691,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SkullWoods,
                    Name = "[dungeon-D3-B1] Skull Woods - Big Key room",
                    Address = 0x154694,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SkullWoods,
                    Name = "[dungeon-D3-B1] Skull Woods - Gibdo/Stalfos room",
                    Address = 0x154697,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.IcePalace,
                    Name = "[dungeon-D5-B1] Ice Palace - Big Key room",
                    Address = 0x15469A,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },

                new Location
                {
                    LateGameItem = true,
                    Region = Region.IcePalace,
                    Name = "[dungeon-D5-B5] Ice Palace - big chest",
                    Address = 0x1546A0,
                    KeysNeeded = 2,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.TowerOfHera,
                    Name = "[dungeon-L3-2F] Tower of Hera - Entrance",
                    Address = 0x1546A3,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },

                new Location
                {
                    LateGameItem = false,
                    Region = Region.EasternPalace,
                    Name = "[dungeon-L1-1F] Eastern Palace - big ball room",
                    Address = 0x1546A9,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.DesertPalace,
                    Name = "[dungeon-L2-B1] Desert Palace - Map room",
                    Address = 0x1546AC,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.EasternPalace,
                    Name = "[dungeon-L1-1F] Eastern Palace - Big key",
                    Address = 0x1546AF,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-040] Link's House",
                    Address = 0x1546B2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-012-1F] Death Mountain - wall of caves - left cave",
                    Address = 0x1546B5,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.DesertPalace,
                    Name = "[dungeon-L2-B1] Desert Palace - Big key room",
                    Address = 0x1546B8,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.LightWorld,
                    Name = "[cave-013] Mimic cave (from Turtle Rock)",
                    Address = 0x1546BB,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SkullWoods,
                    Name = "[dungeon-D3-B1] Skull Woods - south of Fire Rod room",
                    Address = 0x1546BE,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.DesertPalace,
                    Name = "[dungeon-L2-B1] Desert Palace - compass room",
                    Address = 0x1546C1,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-031] Tavern",
                    Address = 0x1546C4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },

                new Location
                {
                    LateGameItem = true,
                    Region = Region.IcePalace,
                    Name = "[dungeon-D5-B1] Ice Palace - compass room",
                    Address = 0x1546CA,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },

                new Location
                {
                    LateGameItem = true,
                    Region = Region.MiseryMire,
                    Name = "[dungeon-D6-B1] Misery Mire - spike room",
                    Address = 0x1546D0,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.IcePalace,
                    Name = "[dungeon-D5-B2] Ice Palace - map room",
                    Address = 0x1546D3,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.IcePalace,
                    Name = "[dungeon-D5-B3] Ice Palace - spike room",
                    Address = 0x1546D6,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.IcePalace,
                    Name = "[dungeon-D5-B5] Ice Palace - b5 up staircase",
                    Address = 0x1546D9,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.TowerOfHera,
                    Name = "[dungeon-L3-1F] Tower of Hera - first floor",
                    Address = 0x1546DC,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-026] chicken house",
                    Address = 0x1546DF,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-063] doorless hut",
                    Address = 0x1546E2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-062] C-shaped house",
                    Address = 0x1546E5,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-044] Aginah's cave",
                    Address = 0x1546E8,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.EasternPalace,
                    Name = "[dungeon-L1-1F] Eastern Palace - map room",
                    Address = 0x1546EB,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.TowerOfHera,
                    Name = "[dungeon-L3-4F] Tower of Hera - big chest",
                    Address = 0x1546EE,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.TowerOfHera,
                    Name = "[dungeon-L3-4F] Tower of Hera - 4F [small chest]",
                    Address = 0x1546F1,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SkullWoods,
                    Name = "[dungeon-D3-B1] Skull Woods - Entrance to part 2",
                    Address = 0x1546F4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.ThievesTown,
                    Name = "[dungeon-D4-B1] Thieves' Town - Bottom left of huge room [top left chest]",
                    Address = 0x1546F7,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.ThievesTown,
                    Name = "[dungeon-D4-B1] Thieves' Town - Bottom left of huge room [bottom right chest]",
                    Address = 0x1546FA,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.ThievesTown,
                    Name = "[dungeon-D4-B1] Thieves' Town - Bottom right of huge room",
                    Address = 0x1546FD,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.ThievesTown,
                    Name = "[dungeon-D4-B1] Thieves' Town - Top left of huge room",
                    Address = 0x154700,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.ThievesTown,
                    Name = "[dungeon-D4-1F] Thieves' Town - Room above boss",
                    Address = 0x154703,
                    KeysNeeded = 2,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.ThievesTown,
                    Name = "[dungeon-D4-B2] Thieves' Town - big chest",
                    Address = 0x154706,
                    KeysNeeded = 2,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.ThievesTown,
                    Name = "[dungeon-D4-B2] Thieves' Town - next to Blind",
                    Address = 0x154709,
                    KeysNeeded = 1,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-1F] Turtle Rock - Chain chomp room",
                    Address = 0x15470C,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-B1] Turtle Rock - big chest",
                    Address = 0x15470F,
                    KeysNeeded = 3,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-1F] Turtle Rock - Map room [left chest]",
                    Address = 0x154712,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-1F] Turtle Rock - Map room [right chest]",
                    Address = 0x154715,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-1F] Turtle Rock - compass room",
                    Address = 0x154718,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-B1] Turtle Rock - big key room",
                    Address = 0x15471B,
                    KeysNeeded = 4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-B2] Turtle Rock - Eye bridge room [top right chest]",
                    Address = 0x15471E,
                    KeysNeeded = 5,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-B2] Turtle Rock - Eye bridge room [top left chest]",
                    Address = 0x154721,
                    KeysNeeded = 5,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-B2] Turtle Rock - Eye bridge room [bottom right chest]",
                    Address = 0x154724,
                    KeysNeeded = 5,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-B2] Turtle Rock - Eye bridge room [bottom left chest]",
                    Address = 0x154727,
                    KeysNeeded = 5,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-B1] Turtle Rock - Roller switch room",
                    Address = 0x15472A,
                    KeysNeeded = 4,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-1F] Dark Palace - big key room",
                    Address = 0x15472D,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-1F] Dark Palace - jump room [right chest]",
                    Address = 0x154730,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-1F] Dark Palace - jump room [left chest]",
                    Address = 0x154733,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-1F] Dark Palace - big chest",
                    Address = 0x154736,
                    KeysNeeded = 3,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-1F] Dark Palace - compass room",
                    Address = 0x154739,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-1F] Dark Palace - spike statue room",
                    Address = 0x15473C,
                    KeysNeeded = 3,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-B1] Dark Palace - turtle stalfos room",
                    Address = 0x15473F,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-B1] Dark Palace - room leading to Helmasaur [left chest]",
                    Address = 0x154742,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-B1] Dark Palace - room leading to Helmasaur [right chest]",
                    Address = 0x154745,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-1F] Dark Palace - statue push room",
                    Address = 0x154748,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-1F] Dark Palace - maze room [top chest]",
                    Address = 0x15474B,
                    KeysNeeded = 3,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-1F] Dark Palace - maze room [bottom chest]",
                    Address = 0x15474E,
                    KeysNeeded = 3,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-B1] Dark Palace - shooter room",
                    Address = 0x154751,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.MiseryMire,
                    Name = "[dungeon-D6-B1] Misery Mire - big hub room",
                    Address = 0x154754,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.MiseryMire,
                    Name = "[dungeon-D6-B1] Misery Mire - end of bridge",
                    Address = 0x154757,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.MiseryMire,
                    Name = "[dungeon-D6-B1] Misery Mire - compass",
                    Address = 0x15475A,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.MiseryMire,
                    Name = "[dungeon-D6-B1] Misery Mire - big chest",
                    Address = 0x15475D,
                    KeysNeeded = 2,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.MiseryMire,
                    Name = "[dungeon-D6-B1] Misery Mire - map room",
                    Address = 0x154760,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.MiseryMire,
                    Name = "[dungeon-D6-B1] Misery Mire - big key",
                    Address = 0x154763,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },

                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-071] Misery Mire west area [left chest]",
                    Address = 0x154769,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
               },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-071] Misery Mire west area [right chest]",
                    Address = 0x15476C,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[dungeon-C-1F] Sanctuary",
                    Address = 0x15476F,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-057-1F] Dark World Death Mountain - cave from top to bottom [top chest]",
                    Address = 0x154772,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-057-1F] Dark World Death Mountain - cave from top to bottom [bottom chest]",
                    Address = 0x154775,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-035] Sahasrahla's Hut [left chest]",
                    Address = 0x154778,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-035] Sahasrahla's Hut [center chest]",
                    Address = 0x15477B,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-035] Sahasrahla's Hut [right chest]",
                    Address = 0x15477E,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-055] Spike cave",
                    Address = 0x154781,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-021] Kakariko well [top chest]",
                    Address = 0x154784,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-021] Kakariko well [left chest row of 3]",
                    Address = 0x154787,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-021] Kakariko well [center chest row of 3]",
                    Address = 0x15478A,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-021] Kakariko well [right chest row of 3]",
                    Address = 0x15478D,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-021] Kakariko well [bottom chest]",
                    Address = 0x154790,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SwampPalace,
                    Name = "[dungeon-D2-1F] Swamp Palace - first room",
                    Address = 0x154793,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SwampPalace,
                    Name = "[dungeon-D2-B1] Swamp Palace - south of hookshot room",
                    Address = 0x154796,
                    KeysNeeded = 3,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SwampPalace,
                    Name = "[dungeon-D2-B1] Swamp Palace - push 4 blocks room",
                    Address = 0x154799,
                    KeysNeeded = 4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SwampPalace,
                    Name = "[dungeon-D2-B1] Swamp Palace - big key room",
                    Address = 0x15479C,
                    KeysNeeded = 4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SwampPalace,
                    Name = "[dungeon-D2-B2] Swamp Palace - flooded room [left chest]",
                    Address = 0x15479F,
                    KeysNeeded = 4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SwampPalace,
                    Name = "[dungeon-D2-B2] Swamp Palace - flooded room [right chest]",
                    Address = 0x1547A2,
                    KeysNeeded = 4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SwampPalace,
                    Name = "[dungeon-D2-B2] Swamp Palace - hidden waterfall door room",
                    Address = 0x1547A5,
                    KeysNeeded = 4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.HyruleCastleTower,
                    Name = "[dungeon-A1-3F] Hyrule Castle Tower - maze room",
                    Address = 0x1547A8,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.HyruleCastleTower,
                    Name = "[dungeon-A1-2F] Hyrule Castle Tower - 2 knife guys room",
                    Address = 0x1547AB,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - north of gap room [top left chest]",
                    Address = 0x1547AE,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - north of gap room [top right chest]",
                    Address = 0x1547B1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - north of gap room [bottom left chest]",
                    Address = 0x1547B4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - north of gap room [bottom right chest]",
                    Address = 0x1547B7,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - west of teleport room [top left chest]",
                    Address = 0x1547BA,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - west of teleport room [top right chest]",
                    Address = 0x1547BD,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - west of teleport room [bottom left chest]",
                    Address = 0x1547C0,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - west of teleport room [bottom right chest]",
                    Address = 0x1547C3,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - north of teleport room",
                    Address = 0x1547C6,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - map room",
                    Address = 0x1547C9,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - big chest",
                    Address = 0x1547CC,
                    BigKeyNeeded = true,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - down right staircase from entrance [left chest]",
                    Address = 0x1547CF,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - down right staircase from entrance [right chest]",
                    Address = 0x1547D2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - above Armos",
                    Address = 0x1547D5,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - east of down right staircase from entrace",
                    Address = 0x1547D8,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - compass room [top left chest]",
                    Address = 0x1547DB,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - compass room [top right chest]",
                    Address = 0x1547DE,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - compass room [bottom left chest]",
                    Address = 0x1547E1,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - compass room [bottom right chest]",
                    Address = 0x1547E4,
                    KeysNeeded = 1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-B1] Ganon's Tower - north of Armos room [bottom chest]",
                    Address = 0x1547E7,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-B1] Ganon's Tower - north of Armos room [left chest]",
                    Address = 0x1547EA,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-B1] Ganon's Tower - north of Armos room [right chest]",
                    Address = 0x1547ED,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },

                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-6F] Ganon's Tower - north of falling floor four torches [top left chest]",
                    Address = 0x1547F3,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-6F] Ganon's Tower - north of falling floor four torches [top right chest]",
                    Address = 0x1547F6,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-6F] Ganon's Tower - before Moldorm",
                    Address = 0x1547F9,
                    KeysNeeded = 1,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-6F] Ganon's Tower - Moldorm room",
                    Address = 0x1547FC,
                    KeysNeeded = 2,
                    BigKeyNeeded = true,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.HyruleCastleEscape,
                    Name = "[dungeon-C-B3] Hyrule Castle - next to Zelda",
                    Address = 0x1547FF,
                    KeysNeeded = 2,
                    CanAccess =
                        have =>
                        true,
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.HyruleCastleEscape,
                    Name = "[dungeon-C-B1] Hyrule Castle - map room",
                    Address = 0x154802,
                    CanAccess =
                        have =>
                        true,
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-022-B1] Thief's hut [top chest]",
                    Address = 0x154805,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-022-B1] Thief's hut [top left chest]",
                    Address = 0x154808,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-022-B1] Thief's hut [top right chest]",
                    Address = 0x15480B,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-022-B1] Thief's hut [bottom left chest]",
                    Address = 0x15480E,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-022-B1] Thief's hut [bottom right chest]",
                    Address = 0x154811,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-073] cave northeast of swamp palace [top chest]",
                    Address = 0x154814,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-073] cave northeast of swamp palace [top middle chest]",
                    Address = 0x154817,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-073] cave northeast of swamp palace [bottom middle chest]",
                    Address = 0x15481A,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-073] cave northeast of swamp palace [bottom chest]",
                    Address = 0x15481D,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-1F] Death Mountain - wall of caves - right cave [top left chest]",
                    Address = 0x154820,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-1F] Death Mountain - wall of caves - right cave [top left middle chest]",
                    Address = 0x154823,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-1F] Death Mountain - wall of caves - right cave [top right middle chest]",
                    Address = 0x154826,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-1F] Death Mountain - wall of caves - right cave [top right chest]",
                    Address = 0x154829,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-1F] Death Mountain - wall of caves - right cave [bottom chest]",
                    Address = 0x15482C,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-B1] Death Mountain - wall of caves - right cave [left chest]",
                    Address = 0x15482F,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-B1] Death Mountain - wall of caves - right cave [right chest]",
                    Address = 0x154832,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-016] cave under rocks west of Santuary",
                    Address = 0x154835,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-050] cave southwest of Lake Hylia [bottom left chest]",
                    Address = 0x154838,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-050] cave southwest of Lake Hylia [top left chest]",
                    Address = 0x15483B,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-050] cave southwest of Lake Hylia [top right chest]",
                    Address = 0x15483E,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-050] cave southwest of Lake Hylia [bottom right chest]",
                    Address = 0x154841,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-051] Ice Cave",
                    Address = 0x154844,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-056] Dark World Death Mountain - cave under boulder [top right chest]",
                    Address = 0x154847,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-056] Dark World Death Mountain - cave under boulder [top left chest]",
                    Address = 0x15484A,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-056] Dark World Death Mountain - cave under boulder [bottom left chest]",
                    Address = 0x15484D,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-056] Dark World Death Mountain - cave under boulder [bottom right chest]",
                    Address = 0x154850,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.HyruleCastleEscape,
                    Name = "[dungeon-C-B1] Escape - final basement room [left chest]",
                    Address = 0x154853,
                    KeysNeeded = 4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.HyruleCastleEscape,
                    Name = "[dungeon-C-B1] Escape - final basement room [middle chest]",
                    Address = 0x154856,
                    KeysNeeded = 4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.HyruleCastleEscape,
                    Name = "[dungeon-C-B1] Escape - final basement room [right chest]",
                    Address = 0x154859,
                    KeysNeeded = 4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },

                //// Getting anything other than the sword here can be bad for progress... may as well keep the sword here since you can't use it if you get it before the uncle.
                //new Location
                //{
                //    LateGameItem = false,
                //    UniqueItemOnly = true,
                //    Region = Region.LightWorld,
                //    Name = "Uncle",
                //    Address = 0x2DF45,
                //    CanAccess =
                //        have =>
                //        true,
                //},
                /*new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "Bottle Vendor",
                    Address = 0x2EB18,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have)
                },
                new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.LightWorld,
                    Name = "Sahasrahla",
                    Address = 0x2F1FC,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                    WriteItemCheck =
                        (rom, item) =>
                        {
                            rom.Seek(0x2F178, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                        }
                },
                new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.DarkWorld,
                    Name = "Flute Boy",
                    Address = 0x330C7,
                    CanAccess =
                        have =>
                        CanAccessLowerDarkWorld(have),
                    WriteItemCheck =
                        (rom, item) =>
                        {
                            rom.Seek(0x31096, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                            //rom.Seek(0x32F9C, SeekOrigin.Begin);
                            //rom.Write(Item.GetCheckLocation(item), 0, 1);
                            rom.Seek(0x33063, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);

                            var compList = new List<ItemType>
                            {
                                ItemType.Bow,
                                ItemType.BowAndArrows,
                                ItemType.RedBoomerang,
                                ItemType.Powder,
                                ItemType.OcarinaInactive,
                                ItemType.MagicMirror,
                                ItemType.TitansMitt,
                                ItemType.RedShield,
                                ItemType.RedMail,
                            };

                            if (!compList.Contains(item))
                            {
                                rom.Seek(0x33067, SeekOrigin.Begin);
                                rom.Write(new []{ (byte)0x01 }, 0, 1);
                            }

                            if (item == ItemType.MirrorShield || item == ItemType.OcarinaActive ||  item == ItemType.Shovel)
                            {
                                rom.Seek(0x33067, SeekOrigin.Begin);
                                rom.Write(new []{ (byte)0x03 }, 0, 1);
                            }
                        }
                },
                new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.LightWorld,
                    Name = "Sick Kid",
                    Address = 0x339CF,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have)
                        && have.Contains(ItemType.Bottle),
                    WriteItemCheck =
                        (rom, item) =>
                        {
                            rom.Seek(0x30D87, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                        }
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "Purple Chest",
                    Address = 0x33D68,
                    CanAccess =
                        have =>
                        CanAccessLowerDarkWorld(have)
                        && have.Contains(ItemType.TitansMitt),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "Hobo",
                    Address = 0x33E7D,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have)
                        && have.Contains(ItemType.Flippers),
                },
                new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.DarkWorld,
                    Name = "Catfish",
                    Address = 0xEE185,
                    CanAccess =
                        have =>
                        CanAccessPyramid(have)
                        && have.Contains(ItemType.PowerGlove)
                        && (have.Contains(ItemType.PegasusBoots)
                            || have.Contains(ItemType.TitansMitt)),
                    WriteItemCheck =
                        (rom, item) =>
                        {
                            rom.Seek(0xEE103, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                            rom.Seek(0xEE11D, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                        }
                },
                //// Zora's appearance is based on if you have flippers or not
                new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.LightWorld,
                    Name = "King Zora",
                    Address = 0xEE1C3,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have)
                        && ((have.Contains(ItemType.PowerGlove)
                                && (have.Contains(ItemType.PegasusBoots)
                                    || have.Contains(ItemType.TitansMitt)))
                            || have.Contains(ItemType.Flippers)),
                    WriteItemCheck =
                        (rom, item) =>
                        {
                            rom.Seek(0x30F17, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                        }
                },
                new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.LightWorld,
                    Name = "Old mountain man",
                    Address = 0xF69FA,
                    CanAccess =
                        have =>
                        CanClimbDeathMountain(have),
                    WriteItemCheck =
                        (rom, item) =>
                        {
                            // this is for the bit that lets you choose where to start in the light world
                            rom.Seek(0x100F3, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                            // old man check
                            rom.Seek(0xF690B, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);

                            var compList = new List<ItemType>
                            {
                                ItemType.Bow,
                                ItemType.BowAndArrows,
                                ItemType.RedBoomerang,
                                ItemType.Powder,
                                ItemType.OcarinaInactive,
                                ItemType.MagicMirror,
                                ItemType.TitansMitt,
                                ItemType.RedShield,
                                ItemType.RedMail,
                            };

                            if (!compList.Contains(item))
                            {
                                // this is for the bit that lets you choose where to start in the light world
                                rom.Seek(0x100F7, SeekOrigin.Begin);
                                rom.Write(new []{ (byte)0x01 }, 0, 1);
                                // old man check
                                rom.Seek(0xF690F, SeekOrigin.Begin);
                                rom.Write(new []{ (byte)0x01 }, 0, 1);
                            }

                            if (item == ItemType.MirrorShield || item == ItemType.OcarinaActive)
                            {
                                // this is for the bit that lets you choose where to start in the light world
                                rom.Seek(0x100F7, SeekOrigin.Begin);
                                rom.Write(new []{ (byte)0x03 }, 0, 1);
                                // old man check
                                rom.Seek(0xF690F, SeekOrigin.Begin);
                                rom.Write(new []{ (byte)0x03 }, 0, 1);
                            }
                        }
                },*/
            };
        }

        private bool CanEnterHyruleCastleTower(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanGetMasterSword(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanAccessEastDarkWorldDeathMountain(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanClimbDeathMountain(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanEnterGanonsTower(List<ItemType> have)
        {
            // items guaranteed here: Cane of Somaria, Ether, Fire Rod, Flippers, Hammer, Hookshot, Magic Mirror, Ocarina, Quake, Titan's Mitt
            return CanEscapeCastle(have);
        }

        private bool CanDefeatDarkPalace(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanDefeatSwampPalace(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanDefeatSkullWoods(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanDefeatThievesTown(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanDefeatIcePalace(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanDefeatMiseryMire(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanDefeatTurtleRock(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanEnterTurtleRock(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanEnterMiseryMire(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanBeInDarkWorld(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanEnterIcePalace(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanEnterThievesTown(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanEnterSkullWoods2(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanEnterSkullWoods(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanEnterSwampPalace(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanAccessLowerDarkWorld(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanEnterDarkPalace(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanAccessPyramid(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanDefeatAgahnim1(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanDefeatTowerOfHera(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanDefeatDesertPalace(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanDefeatEasternPalace(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanEnterTowerOfHera(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanEnterDesertPalace(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanEnterEasternPalace(List<ItemType> have)
        {
            return CanEscapeCastle(have);
        }

        private bool CanEscapeCastle(List<ItemType> have)
        {
            return have.Contains(ItemType.Lamp);
        }

        public List<Location> GetAvailableLocations(List<ItemType> haveItems)
        {
            return (from Location location in Locations where (location.Item == null) && location.CanAccess(haveItems) select location).ToList();
        }

        public List<Location> GetUnavailableLocations(List<ItemType> haveItems)
        {
            return (from Location location in Locations where (location.Item == null) && !location.CanAccess(haveItems) select location).ToList();
        }

        public void TryInsertCandidateItem(List<Location> currentLocations, List<ItemType> candidateItemList, ItemType candidateItem)
        {
            var uniqueItems = GetUniqueItems();
            var badLateGameItem = IsLateGameItem(candidateItem) && !currentLocations.Any(x => x.LateGameItem);
            var needUniqueItem = !uniqueItems.Contains(candidateItem) && currentLocations.All(x => x.UniqueItemOnly);
            var badFirstItem = IsBadFirstItem(candidateItem) && currentLocations.All(x => x.Name == "[cave-040] Link's House");

            if (!badLateGameItem && !needUniqueItem && !badFirstItem)
            {
                candidateItemList.Add(candidateItem);
            }
        }

        private static bool IsBadFirstItem(ItemType item)
        {
            return (item == ItemType.PowerGlove || item == ItemType.TitansMitt || item == ItemType.RedShield || item == ItemType.MirrorShield);
        }

        public int GetInsertedLocation(List<Location> currentLocations, ItemType insertedItem, SeedRandom random)
        {
            int retVal;
            var uniqueItems = GetUniqueItems();
            bool badLateGameItemSpot;
            bool badUniqueItemSpot;
            bool badFirstItemSpot;
            bool unusedUniqueItemSpot;

            do
            {
                retVal = random.Next(currentLocations.Count);

                badLateGameItemSpot = IsLateGameItem(insertedItem) && !currentLocations[retVal].LateGameItem;
                badUniqueItemSpot = !uniqueItems.Contains(insertedItem) && currentLocations[retVal].UniqueItemOnly;
                badFirstItemSpot = IsBadFirstItem(insertedItem) && currentLocations[retVal].Name == "[cave-040] Link's House";
                unusedUniqueItemSpot = uniqueItems.Contains(insertedItem) && !currentLocations[retVal].UniqueItemOnly && currentLocations.Any(x => x.UniqueItemOnly);
            } while (badLateGameItemSpot || badUniqueItemSpot || badFirstItemSpot || unusedUniqueItemSpot);

            return retVal;
        }

        private static bool IsLateGameItem(ItemType item)
        {
            return item == ItemType.TitansMitt || item == ItemType.RedMail || item == ItemType.MirrorShield;
        }

        public ItemType GetInsertedItem(List<Location> currentLocations, List<ItemType> itemPool, SeedRandom random)
        {
            ItemType retVal;
            var uniqueItems = GetUniqueItems();
            bool badLateGameItem;
            bool needUniqueItem;
            bool preferLateGameItem;

            do
            {
                retVal = itemPool[random.Next(itemPool.Count)];

                badLateGameItem = IsLateGameItem(retVal) && !currentLocations.Any(x => x.LateGameItem);
                needUniqueItem = !uniqueItems.Contains(retVal) && currentLocations.All(x => x.UniqueItemOnly);
                preferLateGameItem = !IsLateGameItem(retVal) && currentLocations.Any(x => x.LateGameItem) && itemPool.Any(IsLateGameItem);
            } while (badLateGameItem || needUniqueItem || preferLateGameItem);

            return retVal;
        }

        public List<ItemType> GetImplicitProgressionItems(List<ItemType> have)
        {
            var retVal = new List<ItemType>();

            if (CanEscapeCastle(have) && have.Contains(ItemType.PegasusBoots) && !have.Contains(ItemType.BookOfMudora))
            {
                retVal.Add(ItemType.BookOfMudora);
            }
            if (CanGetMasterSword(have) && !have.Contains(ItemType.Bombos) && CanAccessLowerDarkWorld(have))
            {
                retVal.Add(ItemType.Bombos);
            }
            if (CanGetMasterSword(have) && !have.Contains(ItemType.Ether))
            {
                retVal.Add(ItemType.Ether);
            }
            if (CanEscapeCastle(have) && have.Contains(ItemType.Shovel))
            {
                retVal.Add(ItemType.OcarinaInactive);
                retVal.Add(ItemType.OcarinaActive);
            }

            return retVal;
        }

        public List<ItemType> GetUniqueItems()
        {
            // Please exclude late game items from this list
            return new List<ItemType>
            {
                // advancement items
                ItemType.Bow,
                ItemType.CaneOfSomaria,
                ItemType.FireRod,
                ItemType.Flippers,
                //ItemType.Hammer,
                ItemType.Hookshot,
                ItemType.IceRod,
                //ItemType.Lamp,
                ItemType.MagicMirror,
                ItemType.MoonPearl,
                ItemType.PegasusBoots,
                ItemType.PowerGlove,
                ItemType.Quake,
                ItemType.Shovel,
                //ItemType.TitansMitt,
                ItemType.BlueMail,
                //ItemType.Boomerang,
                ItemType.BugCatchingNet,
                ItemType.Cape,
                //ItemType.MirrorShield,
                //ItemType.RedBoomerang,
                //ItemType.RedMail,
                ItemType.StaffOfByrna,
            };
        }

        public List<ItemType> GetItemPool(SeedRandom random)
        {
            return new List<ItemType>
            {
                // advancement items
                ItemType.Bow,
                ItemType.CaneOfSomaria,
                ItemType.FireRod,
                ItemType.Flippers,
                ItemType.Hammer,
                ItemType.Hookshot,
                ItemType.IceRod,
                ItemType.Lamp,
                ItemType.Lamp,
                ItemType.Lamp,
                //ItemType.L1SwordAndShield,
                ItemType.MagicMirror,
                ItemType.MoonPearl,
                ItemType.PegasusBoots,
                ItemType.PowerGlove,
                ItemType.Quake,
                ItemType.Shovel,
                ItemType.TitansMitt,
                
                // nice-to-have items
                ItemType.BlueMail,
                ItemType.Boomerang,
                ItemType.Boomerang,
                ItemType.Bottle,
                ItemType.Bottle,
                ItemType.Bottle,
                ItemType.Bottle,
                ItemType.BugCatchingNet,
                ItemType.Cape,
                ItemType.HeartContainer,
                ItemType.MirrorShield,
                ItemType.PieceOfHeart,
                ItemType.PieceOfHeart,
                ItemType.PieceOfHeart,
                ItemType.PieceOfHeart,
                ItemType.PieceOfHeart,
                ItemType.PieceOfHeart,
                ItemType.RedBoomerang,
                ItemType.RedMail,
                ItemType.RedShield,
                ItemType.StaffOfByrna,
                
                // other treasure box contents
                ItemType.Arrow,
                ItemType.TenArrows,
                ItemType.TenArrows,
                ItemType.TenArrows,
                ItemType.TenArrows,
                ItemType.TenArrows,
                ItemType.TenArrows,
                ItemType.TenArrows,
                ItemType.TenArrows,
                ItemType.TenArrows,
                ItemType.TenArrows,

                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,
                ItemType.ThreeBombs,

                ItemType.OneRupee,
                ItemType.OneRupee,
                ItemType.FiveRupees,
                ItemType.FiveRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.TwentyRupees,
                ItemType.FiftyRupees,
                ItemType.FiftyRupees,
                ItemType.FiftyRupees,
                ItemType.FiftyRupees,
                ItemType.FiftyRupees,
                ItemType.FiftyRupees,
                ItemType.FiftyRupees,
                ItemType.OneHundredRupees,
                ItemType.ThreeHundredRupees,
                ItemType.ThreeHundredRupees,
            };
        }
    }
}
