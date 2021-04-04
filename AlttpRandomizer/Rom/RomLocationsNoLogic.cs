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
                    Address_JP = 0x154664,
                    Address_US = 0x153300,
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
                    Address_JP = 0x154667,
                    Address_US = 0x153303,
                    CanAccess =
                        have =>
                        true,
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.HyruleCastleEscape,
                    Name = "[dungeon-C-B1] Hyrule Castle - boomerang room",
                    Address_JP = 0x15466A,
                    Address_US = 0x153306,
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
                    Address_JP = 0x15466D,
                    Address_US = 0x153309,
                    CanAccess =
                        have =>
                        CanEnterEasternPalace(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-018] Graveyard - top right grave",
                    Address_JP = 0x154670,
                    Address_US = 0x15330C,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.EasternPalace,
                    Name = "[dungeon-L1-1F] Eastern Palace - big chest",
                    Address_JP = 0x154673,
                    Address_US = 0x15330F,
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
                    Address_JP = 0x15467C,
                    Address_US = 0x153318,
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
                    Address_JP = 0x15467F,
                    Address_US = 0x15331B,
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
                    Address_JP = 0x154682,
                    Address_US = 0x15331E,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.DesertPalace,
                    Name = "[dungeon-L2-B1] Desert Palace - big chest",
                    Address_JP = 0x154685,
                    Address_US = 0x153321,
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
                    Address_JP = 0x154688,
                    Address_US = 0x153324,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.IcePalace,
                    Name = "[dungeon-D5-B4] Ice Palace - above Blue Mail room",
                    Address_JP = 0x15468B,
                    Address_US = 0x153327,
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
                    Address_JP = 0x15468E,
                    Address_US = 0x15332A,
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
                    Address_JP = 0x154691,
                    Address_US = 0x15332D,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SkullWoods,
                    Name = "[dungeon-D3-B1] Skull Woods - Big Key room",
                    Address_JP = 0x154694,
                    Address_US = 0x153330,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SkullWoods,
                    Name = "[dungeon-D3-B1] Skull Woods - Gibdo/Stalfos room",
                    Address_JP = 0x154697,
                    Address_US = 0x153333,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.IcePalace,
                    Name = "[dungeon-D5-B1] Ice Palace - Big Key room",
                    Address_JP = 0x15469A,
                    Address_US = 0x153336,
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
                    Address_JP = 0x1546A0,
                    Address_US = 0x15333C,
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
                    Address_JP = 0x1546A3,
                    Address_US = 0x15333F,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },

                new Location
                {
                    LateGameItem = false,
                    Region = Region.EasternPalace,
                    Name = "[dungeon-L1-1F] Eastern Palace - big ball room",
                    Address_JP = 0x1546A9,
                    Address_US = 0x153345,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.DesertPalace,
                    Name = "[dungeon-L2-B1] Desert Palace - Map room",
                    Address_JP = 0x1546AC,
                    Address_US = 0x153348,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.EasternPalace,
                    Name = "[dungeon-L1-1F] Eastern Palace - Big key",
                    Address_JP = 0x1546AF,
                    Address_US = 0x15334B,
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
                    Address_JP = 0x1546B2,
                    Address_US = 0x15334E,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                    Item = new Item(ItemType.PegasusBoots),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-012-1F] Death Mountain - wall of caves - left cave",
                    Address_JP = 0x1546B5,
                    Address_US = 0x153351,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.DesertPalace,
                    Name = "[dungeon-L2-B1] Desert Palace - Big key room",
                    Address_JP = 0x1546B8,
                    Address_US = 0x153354,
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
                    Address_JP = 0x1546BB,
                    Address_US = 0x153357,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SkullWoods,
                    Name = "[dungeon-D3-B1] Skull Woods - south of Fire Rod room",
                    Address_JP = 0x1546BE,
                    Address_US = 0x15335A,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.DesertPalace,
                    Name = "[dungeon-L2-B1] Desert Palace - compass room",
                    Address_JP = 0x1546C1,
                    Address_US = 0x15335D,
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
                    Address_JP = 0x1546C4,
                    Address_US = 0x153360,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },

                new Location
                {
                    LateGameItem = true,
                    Region = Region.IcePalace,
                    Name = "[dungeon-D5-B1] Ice Palace - compass room",
                    Address_JP = 0x1546CA,
                    Address_US = 0x153366,
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
                    Address_JP = 0x1546D0,
                    Address_US = 0x15336C,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.IcePalace,
                    Name = "[dungeon-D5-B2] Ice Palace - map room",
                    Address_JP = 0x1546D3,
                    Address_US = 0x15336F,
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
                    Address_JP = 0x1546D6,
                    Address_US = 0x153372,
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
                    Address_JP = 0x1546D9,
                    Address_US = 0x153375,
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
                    Address_JP = 0x1546DC,
                    Address_US = 0x153378,
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
                    Address_JP = 0x1546DF,
                    Address_US = 0x15337B,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-063] doorless hut",
                    Address_JP = 0x1546E2,
                    Address_US = 0x15337E,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-062] C-shaped house",
                    Address_JP = 0x1546E5,
                    Address_US = 0x153381,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-044] Aginah's cave",
                    Address_JP = 0x1546E8,
                    Address_US = 0x153384,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.EasternPalace,
                    Name = "[dungeon-L1-1F] Eastern Palace - map room",
                    Address_JP = 0x1546EB,
                    Address_US = 0x153387,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.TowerOfHera,
                    Name = "[dungeon-L3-4F] Tower of Hera - big chest",
                    Address_JP = 0x1546EE,
                    Address_US = 0x15338A,
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
                    Address_JP = 0x1546F1,
                    Address_US = 0x15338D,
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
                    Address_JP = 0x1546F4,
                    Address_US = 0x153390,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.ThievesTown,
                    Name = "[dungeon-D4-B1] Thieves' Town - Bottom left of huge room [top left chest]",
                    Address_JP = 0x1546F7,
                    Address_US = 0x153393,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.ThievesTown,
                    Name = "[dungeon-D4-B1] Thieves' Town - Bottom left of huge room [bottom right chest]",
                    Address_JP = 0x1546FA,
                    Address_US = 0x153396,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.ThievesTown,
                    Name = "[dungeon-D4-B1] Thieves' Town - Bottom right of huge room",
                    Address_JP = 0x1546FD,
                    Address_US = 0x153399,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.ThievesTown,
                    Name = "[dungeon-D4-B1] Thieves' Town - Top left of huge room",
                    Address_JP = 0x154700,
                    Address_US = 0x15339C,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.ThievesTown,
                    Name = "[dungeon-D4-1F] Thieves' Town - Room above boss",
                    Address_JP = 0x154703,
                    Address_US = 0x15339F,
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
                    Address_JP = 0x154706,
                    Address_US = 0x1533A2,
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
                    Address_JP = 0x154709,
                    Address_US = 0x1533A5,
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
                    Address_JP = 0x15470C,
                    Address_US = 0x1533A8,
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
                    Address_JP = 0x15470F,
                    Address_US = 0x1533AB,
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
                    Address_JP = 0x154712,
                    Address_US = 0x1533AE,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-1F] Turtle Rock - Map room [right chest]",
                    Address_JP = 0x154715,
                    Address_US = 0x1533B1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-1F] Turtle Rock - compass room",
                    Address_JP = 0x154718,
                    Address_US = 0x1533B4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.TurtleRock,
                    Name = "[dungeon-D7-B1] Turtle Rock - big key room",
                    Address_JP = 0x15471B,
                    Address_US = 0x1533B7,
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
                    Address_JP = 0x15471E,
                    Address_US = 0x1533BA,
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
                    Address_JP = 0x154721,
                    Address_US = 0x1533BD,
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
                    Address_JP = 0x154724,
                    Address_US = 0x1533C0,
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
                    Address_JP = 0x154727,
                    Address_US = 0x1533C3,
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
                    Address_JP = 0x15472A,
                    Address_US = 0x1533C6,
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
                    Address_JP = 0x15472D,
                    Address_US = 0x1533C9,
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
                    Address_JP = 0x154730,
                    Address_US = 0x1533CC,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-1F] Dark Palace - jump room [left chest]",
                    Address_JP = 0x154733,
                    Address_US = 0x1533CF,
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
                    Address_JP = 0x154736,
                    Address_US = 0x1533D2,
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
                    Address_JP = 0x154739,
                    Address_US = 0x1533D5,
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
                    Address_JP = 0x15473C,
                    Address_US = 0x1533D8,
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
                    Address_JP = 0x15473F,
                    Address_US = 0x1533DB,
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
                    Address_JP = 0x154742,
                    Address_US = 0x1533DE,
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
                    Address_JP = 0x154745,
                    Address_US = 0x1533E1,
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
                    Address_JP = 0x154748,
                    Address_US = 0x1533E4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkPalace,
                    Name = "[dungeon-D1-1F] Dark Palace - maze room [top chest]",
                    Address_JP = 0x15474B,
                    Address_US = 0x1533E7,
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
                    Address_JP = 0x15474E,
                    Address_US = 0x1533EA,
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
                    Address_JP = 0x154751,
                    Address_US = 0x1533ED,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.MiseryMire,
                    Name = "[dungeon-D6-B1] Misery Mire - big hub room",
                    Address_JP = 0x154754,
                    Address_US = 0x1533F0,
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
                    Address_JP = 0x154757,
                    Address_US = 0x1533F3,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.MiseryMire,
                    Name = "[dungeon-D6-B1] Misery Mire - compass",
                    Address_JP = 0x15475A,
                    Address_US = 0x1533F6,
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
                    Address_JP = 0x15475D,
                    Address_US = 0x1533F9,
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
                    Address_JP = 0x154760,
                    Address_US = 0x1533FC,
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
                    Address_JP = 0x154763,
                    Address_US = 0x1533FF,
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
                    Address_JP = 0x154769,
                    Address_US = 0x153405,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
               },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-071] Misery Mire west area [right chest]",
                    Address_JP = 0x15476C,
                    Address_US = 0x153408,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[dungeon-C-1F] Sanctuary",
                    Address_JP = 0x15476F,
                    Address_US = 0x15340B,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-057-1F] Dark World Death Mountain - cave from top to bottom [top chest]",
                    Address_JP = 0x154772,
                    Address_US = 0x15340E,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-057-1F] Dark World Death Mountain - cave from top to bottom [bottom chest]",
                    Address_JP = 0x154775,
                    Address_US = 0x153411,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-035] Sahasrahla's Hut [left chest]",
                    Address_JP = 0x154778,
                    Address_US = 0x153414,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-035] Sahasrahla's Hut [center chest]",
                    Address_JP = 0x15477B,
                    Address_US = 0x153417,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-035] Sahasrahla's Hut [right chest]",
                    Address_JP = 0x15477E,
                    Address_US = 0x15341A,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-055] Spike cave",
                    Address_JP = 0x154781,
                    Address_US = 0x15341D,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-021] Kakariko well [top chest]",
                    Address_JP = 0x154784,
                    Address_US = 0x153420,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-021] Kakariko well [left chest row of 3]",
                    Address_JP = 0x154787,
                    Address_US = 0x153423,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-021] Kakariko well [center chest row of 3]",
                    Address_JP = 0x15478A,
                    Address_US = 0x153426,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-021] Kakariko well [right chest row of 3]",
                    Address_JP = 0x15478D,
                    Address_US = 0x153429,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-021] Kakariko well [bottom chest]",
                    Address_JP = 0x154790,
                    Address_US = 0x15342C,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SwampPalace,
                    Name = "[dungeon-D2-1F] Swamp Palace - first room",
                    Address_JP = 0x154793,
                    Address_US = 0x15342F,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.SwampPalace,
                    Name = "[dungeon-D2-B1] Swamp Palace - south of hookshot room",
                    Address_JP = 0x154796,
                    Address_US = 0x153432,
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
                    Address_JP = 0x154799,
                    Address_US = 0x153435,
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
                    Address_JP = 0x15479C,
                    Address_US = 0x153438,
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
                    Address_JP = 0x15479F,
                    Address_US = 0x15343B,
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
                    Address_JP = 0x1547A2,
                    Address_US = 0x15343E,
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
                    Address_JP = 0x1547A5,
                    Address_US = 0x153441,
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
                    Address_JP = 0x1547A8,
                    Address_US = 0x153444,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.HyruleCastleTower,
                    Name = "[dungeon-A1-2F] Hyrule Castle Tower - 2 knife guys room",
                    Address_JP = 0x1547AB,
                    Address_US = 0x153447,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - north of gap room [top left chest]",
                    Address_JP = 0x1547AE,
                    Address_US = 0x15344A,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - north of gap room [top right chest]",
                    Address_JP = 0x1547B1,
                    Address_US = 0x15344D,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - north of gap room [bottom left chest]",
                    Address_JP = 0x1547B4,
                    Address_US = 0x153450,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - north of gap room [bottom right chest]",
                    Address_JP = 0x1547B7,
                    Address_US = 0x153453,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - west of teleport room [top left chest]",
                    Address_JP = 0x1547BA,
                    Address_US = 0x153456,
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
                    Address_JP = 0x1547BD,
                    Address_US = 0x153459,
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
                    Address_JP = 0x1547C0,
                    Address_US = 0x15345C,
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
                    Address_JP = 0x1547C3,
                    Address_US = 0x15345F,
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
                    Address_JP = 0x1547C6,
                    Address_US = 0x153462,
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
                    Address_JP = 0x1547C9,
                    Address_US = 0x153465,
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
                    Address_JP = 0x1547CC,
                    Address_US = 0x153468,
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
                    Address_JP = 0x1547CF,
                    Address_US = 0x15346B,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - down right staircase from entrance [right chest]",
                    Address_JP = 0x1547D2,
                    Address_US = 0x15346E,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - above Armos",
                    Address_JP = 0x1547D5,
                    Address_US = 0x153471,
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
                    Address_JP = 0x1547D8,
                    Address_US = 0x153474,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.GanonsTower,
                    Name = "[dungeon-A2-1F] Ganon's Tower - compass room [top left chest]",
                    Address_JP = 0x1547DB,
                    Address_US = 0x153477,
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
                    Address_JP = 0x1547DE,
                    Address_US = 0x15347A,
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
                    Address_JP = 0x1547E1,
                    Address_US = 0x15347D,
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
                    Address_JP = 0x1547E4,
                    Address_US = 0x153480,
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
                    Address_JP = 0x1547E7,
                    Address_US = 0x153483,
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
                    Address_JP = 0x1547EA,
                    Address_US = 0x153486,
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
                    Address_JP = 0x1547ED,
                    Address_US = 0x153489,
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
                    Address_JP = 0x1547F3,
                    Address_US = 0x15348F,
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
                    Address_JP = 0x1547F6,
                    Address_US = 0x153492,
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
                    Address_JP = 0x1547F9,
                    Address_US = 0x153495,
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
                    Address_JP = 0x1547FC,
                    Address_US = 0x153498,
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
                    Address_JP = 0x1547FF,
                    Address_US = 0x15349B,
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
                    Address_JP = 0x154802,
                    Address_US = 0x15349E,
                    CanAccess =
                        have =>
                        true,
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-022-B1] Thief's hut [top chest]",
                    Address_JP = 0x154805,
                    Address_US = 0x1534A1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-022-B1] Thief's hut [top left chest]",
                    Address_JP = 0x154808,
                    Address_US = 0x1534A4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-022-B1] Thief's hut [top right chest]",
                    Address_JP = 0x15480B,
                    Address_US = 0x1534A7,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-022-B1] Thief's hut [bottom left chest]",
                    Address_JP = 0x15480E,
                    Address_US = 0x1534AA,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-022-B1] Thief's hut [bottom right chest]",
                    Address_JP = 0x154811,
                    Address_US = 0x1534AD,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-073] cave northeast of swamp palace [top chest]",
                    Address_JP = 0x154814,
                    Address_US = 0x1534B0,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-073] cave northeast of swamp palace [top middle chest]",
                    Address_JP = 0x154817,
                    Address_US = 0x1534B3,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-073] cave northeast of swamp palace [bottom middle chest]",
                    Address_JP = 0x15481A,
                    Address_US = 0x1534B6,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-073] cave northeast of swamp palace [bottom chest]",
                    Address_JP = 0x15481D,
                    Address_US = 0x1534B9,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-1F] Death Mountain - wall of caves - right cave [top left chest]",
                    Address_JP = 0x154820,
                    Address_US = 0x1534BC,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-1F] Death Mountain - wall of caves - right cave [top left middle chest]",
                    Address_JP = 0x154823,
                    Address_US = 0x1534BF,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-1F] Death Mountain - wall of caves - right cave [top right middle chest]",
                    Address_JP = 0x154826,
                    Address_US = 0x1534C2,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-1F] Death Mountain - wall of caves - right cave [top right chest]",
                    Address_JP = 0x154829,
                    Address_US = 0x1534C5,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-1F] Death Mountain - wall of caves - right cave [bottom chest]",
                    Address_JP = 0x15482C,
                    Address_US = 0x1534C8,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-B1] Death Mountain - wall of caves - right cave [left chest]",
                    Address_JP = 0x15482F,
                    Address_US = 0x1534CB,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-009-B1] Death Mountain - wall of caves - right cave [right chest]",
                    Address_JP = 0x154832,
                    Address_US = 0x1534CE,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-016] cave under rocks west of Santuary",
                    Address_JP = 0x154835,
                    Address_US = 0x1534D1,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-050] cave southwest of Lake Hylia [bottom left chest]",
                    Address_JP = 0x154838,
                    Address_US = 0x1534D4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-050] cave southwest of Lake Hylia [top left chest]",
                    Address_JP = 0x15483B,
                    Address_US = 0x1534D7,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-050] cave southwest of Lake Hylia [top right chest]",
                    Address_JP = 0x15483E,
                    Address_US = 0x1534DA,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-050] cave southwest of Lake Hylia [bottom right chest]",
                    Address_JP = 0x154841,
                    Address_US = 0x1534DD,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "[cave-051] Ice Cave",
                    Address_JP = 0x154844,
                    Address_US = 0x1534E0,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-056] Dark World Death Mountain - cave under boulder [top right chest]",
                    Address_JP = 0x154847,
                    Address_US = 0x1534E3,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-056] Dark World Death Mountain - cave under boulder [top left chest]",
                    Address_JP = 0x15484A,
                    Address_US = 0x1534E6,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-056] Dark World Death Mountain - cave under boulder [bottom left chest]",
                    Address_JP = 0x15484D,
                    Address_US = 0x1534E9,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = true,
                    Region = Region.DarkWorld,
                    Name = "[cave-056] Dark World Death Mountain - cave under boulder [bottom right chest]",
                    Address_JP = 0x154850,
                    Address_US = 0x1534EC,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.HyruleCastleEscape,
                    Name = "[dungeon-C-B1] Escape - final basement room [left chest]",
                    Address_JP = 0x154853,
                    Address_US = 0x1534EF,
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
                    Address_JP = 0x154856,
                    Address_US = 0x1534F2,
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
                    Address_JP = 0x154859,
                    Address_US = 0x1534F5,
                    KeysNeeded = 4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                /*
                // Getting anything other than the sword here can be bad for progress... may as well keep the sword here since you can't use it if you get it before the uncle.
                new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.LightWorld,
                    Name = "Uncle",
                    Address_JP = 0x2DF45,
                    Address_US = 0xD23BA,
                    CanAccess =
                        have =>
                        true,
                },*/  // Item Checks + Location
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "Bottle Vendor",
                    Address_JP = 0xD23BA,
                    Address_US = 0xD15E2,
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
                    Address_JP = 0xDF4FA,
                    Address_US = 0xDE682,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                    WriteItemCheck =
                        (rom, item, romRegion) =>
                        {
                            rom.Seek(romRegion ? 0xDF378 : 0xDE500, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                        }
                },
                /*new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.LightWorld,
                    Name = "Grove Digging",
                    Address_JP = 0xDF4FA,
                    Address_US = 0xDE682,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                    WriteItemCheck =
                        (rom, item, romRegion) =>
                        {
                            rom.Seek(romRegion ? 0xDF378 : 0xDE500, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                        }
                },*/ // Item Checks (0x2E) + Location (0x14)
                new Location // Considering to banish this guy out of my game, dumb stumb kid.
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.DarkWorld,
                    Name = "Flute Boy",
                    Address_JP = 0xD376E,
                    Address_US = 0xD2996,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                    Item = new Item(ItemType.Nothing),
                    /*WriteItemCheck =
                        (rom, item, romRegion) =>
                        {
                            rom.Seek(0x31096, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);

                            rom.Seek(0xD2870  0x33063, SeekOrigin.Begin);
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
                                ItemType.Shovel,
                            };

                            if (!compList.Contains(item))
                            {
                                rom.Seek(0xD2160, SeekOrigin.Begin);
                                rom.Write(new []{ (byte)0x01 }, 0, 1);
                            }

                            if (item == ItemType.MirrorShield || item == ItemType.OcarinaActive)
                            {
                                rom.Seek(0x33067, SeekOrigin.Begin);
                                rom.Write(new []{ (byte)0x03 }, 0, 1);
                            }
                        }*/
                },
                new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.LightWorld,
                    Name = "Sick Kid",
                    Address_JP = 0xDD18C,
                    Address_US = 0xDC316,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                    WriteItemCheck =
                        (rom, item, romRegion) =>
                        {
                            rom.Seek(romRegion ? 0xDD128 : 0xDC2B0, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                        }
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "Purple Chest",
                    Address_JP = 0xF28E0,
                    Address_US = 0xF19C4,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    Region = Region.LightWorld,
                    Name = "Hobo",
                    Address_JP = 0xDE44E,
                    Address_US = 0xDD5D6,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                },
                new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.DarkWorld,
                    Name = "Catfish",
                    Address_JP = 0x10621A,
                    Address_US = 0x10529E,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                    WriteItemCheck =
                        (rom, item, romRegion) =>
                        {
                            rom.Seek(romRegion ? 0xDD038 : 0xF79A0, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                        }
                },
                new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.LightWorld,
                    Name = "King Zora",
                    Address_JP = 0xEA8C4,
                    Address_US = 0x39938,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                    WriteItemCheck =
                        (rom, item, romRegion) =>
                        {
                            rom.Seek(romRegion ? 0xEA8C4 : 0xE99B0, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                        }
                },
                new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.LightWorld,
                    Name = "Old mountain man",
                    Address_JP = 0xDDD10,
                    Address_US = 0xDCE9A,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                    WriteItemCheck =
                        (rom, item, romRegion) =>
                        {
                            // old man check
                            rom.Seek(romRegion ? 0xDDC64 : 0xDCDEC, SeekOrigin.Begin);
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
                                // old man check
                                rom.Seek(romRegion ? 0xDDC54 : 0xDCDDC, SeekOrigin.Begin);
                                rom.Write(new []{ (byte)0x01 }, 0, 1);
                            }

                            if (item == ItemType.MirrorShield || item == ItemType.OcarinaActive)
                            {
                                // old man check
                                rom.Seek(romRegion ? 0xDDC54 : 0xDCDDC, SeekOrigin.Begin);
                                rom.Write(new []{ (byte)0x03 }, 0, 1);
                            }
                        }
                },
                new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.LightWorld,
                    Name = "Library",
                    Address_JP = 0xD8A02,
                    Address_US = 0xD7C12,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                    WriteItemCheck =
                        (rom, item, romRegion) =>
                        {
                            rom.Seek(romRegion ? 0xD81C0 : 0xD73D0, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                        }
                },
                new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.LightWorld,
                    Name = "Mushroom",
                    Address_JP = 0xF6534,
                    Address_US = 0xF5618,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                    WriteItemCheck =
                        (rom, item, romRegion) =>
                        {
                            rom.Seek(romRegion ? 0xF64A4 : 0xF5588, SeekOrigin.Begin);
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
                                rom.Seek(romRegion ? 0xF64A7 : 0xF558B, SeekOrigin.Begin);
                                rom.Write(new []{ (byte)0x01 }, 0, 1);
                            }

                            if (item == ItemType.MirrorShield || item == ItemType.OcarinaActive)
                            {
                                rom.Seek(romRegion ? 0xF64A7 : 0xF558B, SeekOrigin.Begin);
                                rom.Write(new []{ (byte)0x03 }, 0, 1);
                            }
                        }
                },
                // Should probably stay Powder Slot Sharing with Shroom.
                /*new Location
                {
                    LateGameItem = false,
                    UniqueItemOnly = true,
                    Region = Region.LightWorld,
                    Name = "Powder",
                    Address_JP = 0x110B4E,
                    Address_US = 0x10FBA6,
                    CanAccess =
                        have =>
                        CanEscapeCastle(have),
                    WriteItemCheck =
                        (rom, item, romRegion) =>
                        {
                            rom.Seek(0xEE103, SeekOrigin.Begin);
                            rom.Write(Item.GetCheckLocation(item), 0, 1);
                        }
                },*/ // Item Checks 
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

        public List<ItemType> GetInLogicItems(List<ItemType> have)
        {
            var retVal = new List<ItemType>();

            foreach (Location location in Locations)
            {
                if (location.Item != null && location.CanAccess(have))
                    retVal.Add(location.Item.Type);
            }

            foreach (ItemType item in GetImplicitProgressionItems(have))
            {
                retVal.Add(item);
            }

            return retVal;
        }
        public bool isItemEarly(ItemType item, List<ItemType> have)
        {
            if (IsLateGameItem(item))                           // Place Late Game Items first into late game spots.
                return false;

            int countUnique = 0;
            foreach (ItemType it in have)
            {
                if (IsLateGameItem(it))                         // If there are still Late Game Items Left, wait till those are out
                    return true;
                if (GetUniqueItems().Contains(it))
                    countUnique++;
            }

            return                                              // If there are either no Unique Items Left to be placed or the Item is Unique, It's good.
                !(GetUniqueItems().Contains(item) || countUnique == 0);
        }

        public bool isLocationEarly(Location loc)
        {
            int countUnique = 0;
            foreach (Location lt in Locations)
            {
                if (lt.Item == null && lt.UniqueItemOnly)
                    countUnique++;
            }

            return
                !(loc.UniqueItemOnly || countUnique == 0);

        }

        public bool testLocation(ItemType item, Location loc)
        {

            bool LateGame = loc.LateGameItem || !IsLateGameItem(item);
            bool Unique = loc.UniqueItemOnly || !GetUniqueItems().Contains(item);

            return LateGame || Unique;
        }
        public List<Location> getEmptyLocation()
        {
            return (from Location location in Locations where (location.Item == null) select location).ToList();
        }
        public List<Location> getEmptyLateLocation()
        {
            return (from Location location in Locations where (location.Item == null) && !location.LateGameItem select location).ToList();
        }
        public List<Location> getEmptyUniqueLocation()
        {
            return (from Location location in Locations where (location.Item == null) && !location.UniqueItemOnly select location).ToList();
        }

        public List<ItemType> GetImplicitProgressionItems(List<ItemType> have)
        {
            var retVal = new List<ItemType>();

            if (CanEscapeCastle(have))
            {
                retVal.Add(ItemType.BookOfMudora);
            }
            if (CanEscapeCastle(have))
            {
                retVal.Add(ItemType.Bombos);
            }
            if (CanEscapeCastle(have))
            {
                retVal.Add(ItemType.Ether);
            }
            if (CanEscapeCastle(have))
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
                ItemType.Hammer,
                ItemType.Hookshot,
                ItemType.IceRod,
                ItemType.Lamp,
                ItemType.MagicMirror,
                ItemType.MoonPearl,
                ItemType.PegasusBoots,
                ItemType.PowerGlove,
                ItemType.Quake,
                ItemType.Shovel,
                ItemType.TitansMitt,
                ItemType.BlueMail,
                ItemType.Boomerang,
                ItemType.BugCatchingNet,
                ItemType.Cape,
                ItemType.MirrorShield,
                ItemType.RedBoomerang,
                ItemType.RedMail,
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
                ItemType.Mushroom,
                ItemType.Lamp,
                ItemType.Lamp,
                ItemType.Lamp,
                // ItemType.L1SwordAndShield,
                ItemType.MagicMirror,
                ItemType.MoonPearl,
                ItemType.PegasusBoots,
                ItemType.BookOfMudora,
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
