using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlttpRandomizer.Random;

namespace AlttpRandomizer.Rom
{
    public interface IRomLocations
    {
        List<Location> Locations { get; set; }
        string DifficultyName { get; }
        string SeedFileString { get; }
        string SeedRomString { get; }

        void ResetLocations();
        List<Location> GetAvailableLocations(List<ItemType> haveItems);
        List<Location> GetUnavailableLocations(List<ItemType> haveItems);
        List<ItemType> GetInLogicItems(List<ItemType> have);
        bool isItemEarly(ItemType item, List<ItemType> have);
        List<Location> getEmptyLocation();
        List<Location> getEmptyLateLocation(ItemType item, List<ItemType> reachItems);
        List<Location> getEmptyUniqueLocation(ItemType item, List<ItemType> reachItems);
        bool testLocation(ItemType ítem, Location loc);
        List<ItemType> GetAdvancementPool();
        List<ItemType> GetFillerPool();
	    List<ItemType> GetImplicitProgressionItems(List<ItemType> haveItems);
    }
}
