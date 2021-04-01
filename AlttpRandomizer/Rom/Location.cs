﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlttpRandomizer.Rom
{
    public enum Region
    {
        Progression,
        LightWorld,
        DarkWorld,
        HyruleCastleEscape,
        EasternPalace,
        DesertPalace,
        TowerOfHera,
        HyruleCastleTower,
        DarkPalace,
        SwampPalace,
        SkullWoods,
        ThievesTown,
        IcePalace,
        MiseryMire,
        TurtleRock,
        GanonsTower,
    }

    public delegate bool Access(List<ItemType> have);

    public class Location
    {
        public string Name { get; set; }
        public long Address_JP { get; set; }
        public long Address_US { get; set; }
        public bool LateGameItem { get; set; }
        public bool UniqueItemOnly { get; set; }
        public int KeysNeeded { get; set; }
        public bool BigKeyNeeded { get; set; }
        public Access CanAccess { get; set; }
        public Action<FileStream, ItemType> WriteItemCheck { get; set; }
        public Item Item { get; set; }
        public Region Region { get; set; }
    }
}
