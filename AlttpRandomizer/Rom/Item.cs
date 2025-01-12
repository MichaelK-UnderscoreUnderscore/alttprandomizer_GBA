﻿using System;

namespace AlttpRandomizer.Rom
{
    public enum ItemType
    {
		Nothing = 0xFF,
		L1SwordAndShield = 0x00, // can't be used until after uncle dies
        L2Sword = 0x01, // crashes game
        L3Sword = 0x02, // can't be used until after uncle dies
        L4Sword = 0x03, // can't be used until after uncle dies
        BlueShield = 0x04, // can't be used until after uncle dies
        RedShield = 0x05, // can't be used until after uncle dies
        MirrorShield = 0x06, // can't be used until after uncle dies
        FireRod = 0x07,
        IceRod = 0x08,
        Hammer = 0x09,
        Hookshot = 0x0a,
        Bow = 0x0b,
        Boomerang = 0x0c, // alt: 10 arrows
        Powder = 0x0d,
        Bee = 0x0e, // does nothing if no bottle
        Bombos = 0x0f,
        Ether = 0x10,
        Quake = 0x11,
        Lamp = 0x12, // alt: 5 rupees
        Shovel = 0x13,
        OcarinaInactive = 0x14,
        CaneOfSomaria = 0x15,
        Bottle = 0x16,
        PieceOfHeart = 0x17,
        StaffOfByrna = 0x18,
        Cape = 0x19,
        MagicMirror = 0x1a,
        PowerGlove = 0x1b,
        TitansMitt = 0x1c,
        BookOfMudora = 0x1d,
        Flippers = 0x1e,
        MoonPearl = 0x1f,
        Crystal = 0x20, // crashes game
        BugCatchingNet = 0x21,
        BlueMail = 0x22,
        RedMail = 0x23,
        Key = 0x24,
        Compass = 0x25,
        HeartContainerNoAnimation = 0x26,
        Bomb = 0x27,
        ThreeBombs = 0x28,
        Mushroom = 0x29,
        RedBoomerang = 0x2a,
        RedPotion = 0x2b, // does nothing if no bottle
        GreenPotion = 0x2c, // does nothing if no bottle
        BluePotion = 0x2d, // does nothing if no bottle
        RedPotion2 = 0x2e, // does nothing if no bottle
        GreenPotion2 = 0x2f, // does nothing if no bottle
        BluePotion2 = 0x30, // does nothing if no bottle
        TenBombs = 0x31,
        BigKey = 0x32,
        Map = 0x33,
        OneRupee = 0x34,
        FiveRupees = 0x35,
        TwentyRupees = 0x36,
        PendantOfCourage = 0x37, // green
        PendantOfWisdom = 0x38, // red
        PendantOfPower = 0x39, // blue
        BowAndArrows = 0x3a,
        BowAndSilverArrows = 0x3b,
        Bee2 = 0x3c, // does nothing if no bottle
        Fairy = 0x3d, // does nothing if no bottle
        HeartContainerNoDialog = 0x3e,
        HeartContainer = 0x3f,
        OneHundredRupees = 0x40,
        FiftyRupees = 0x41,
        Heart = 0x42,
        Arrow = 0x43,
        TenArrows = 0x44,
        SmallMagic = 0x45,
        ThreeHundredRupees = 0x46,
        TwentyRupees2 = 0x47,
        GoodBee = 0x48, // does nothing if no bottle
        L1Sword = 0x49, // can't be used until after uncle dies
        OcarinaActive = 0x4a,
        PegasusBoots = 0x4b,
	}

	public class Item
    {
        private ItemType type;
        public char HexValue { get; set; }

        public Item(ItemType insertedItem)
        {
            Type = insertedItem;
        }

        public ItemType Type
        {
            get { return type; }
            set
            {
                type = value;
                HexValue = (char)type;
            }
        }

        public static byte[] GetCheckLocation(ItemType item, bool Logic = true)
        {
            byte retVal;

            if (Logic == false)
            {
                return new byte[] { 0xFF };
            }
            switch (item)
            {
                case ItemType.Bow:
                case ItemType.BowAndArrows:
                case ItemType.BowAndSilverArrows:
                    retVal = 0x20;
                    break;
                case ItemType.Boomerang:
                case ItemType.RedBoomerang:
                    retVal = 0x21;
                    break;
                case ItemType.Hookshot:
                    retVal = 0x22;
                    break;
                case ItemType.Mushroom:
                case ItemType.Powder:
                    retVal = 0x24;
                    break;
                case ItemType.FireRod:
                    retVal = 0x26;
                    break;
                case ItemType.IceRod:
                    retVal = 0x27;
                    break;
                case ItemType.Bombos:
                    retVal = 0x28;
                    break;
                case ItemType.Ether:
                    retVal = 0x29;
                    break;
                case ItemType.Quake:
                    retVal = 0x2A;
                    break;
                case ItemType.Lamp:
                    retVal = 0x2C;
                    break;
                case ItemType.Hammer:
                    retVal = 0x2D;
                    break;
                case ItemType.OcarinaActive:
                case ItemType.OcarinaInactive:
                    retVal = 0x2E;
                    break;
                case ItemType.BugCatchingNet:
                    retVal = 0x2F;
                    break;
                case ItemType.BookOfMudora:
                    retVal = 0x30;
                    break;
                case ItemType.Shovel:
                    retVal = 0x32;
                    break;
                case ItemType.CaneOfSomaria:
                    retVal = 0x33;
                    break;
                case ItemType.StaffOfByrna:
                    retVal = 0x34;
                    break;
                case ItemType.Cape:
                    retVal = 0x35;
                    break;
                case ItemType.MagicMirror:
                    retVal = 0x36;
                    break;
                case ItemType.PowerGlove:
                case ItemType.TitansMitt:
                    retVal = 0x38;
                    break;
                case ItemType.PegasusBoots:
                    retVal = 0x39;
                    break;
                case ItemType.Flippers:
                    retVal = 0x3A;
                    break;
                case ItemType.MoonPearl:
                    retVal = 0x3B;
                    break;
                case ItemType.L1Sword:
                case ItemType.L1SwordAndShield:
                case ItemType.L2Sword:
                case ItemType.L3Sword:
                case ItemType.L4Sword:
                    retVal = 0x3D;
                    break;
                case ItemType.BlueShield:
                case ItemType.RedShield:
                case ItemType.MirrorShield:
                    retVal = 0x3E;
                    break;
                case ItemType.BlueMail:
                case ItemType.RedMail:
                    retVal = 0x3F;
                    break;
                default:
                    throw new ArgumentException("Item must be a unique item.", "item");
            }

            return new[] { retVal };
        }
    }
}
