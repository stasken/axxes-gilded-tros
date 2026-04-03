using System;
using System.Linq;

namespace GildedTros.App
{
    public static class ItemUpdaterFactory
    {
        private static readonly string[] SmellyItems =
        {
            "Duplicate Code",
            "Long Methods",
            "Ugly Variable Names"
        };

        public static ItemUpdater Create(Item item)
        {
            return item.Name switch
            {
                "Good Wine" => new GoodWineUpdater(item),

                "B-DAWG Keychain" => new LegendaryItemUpdater(item),

                var name when name.Contains("Backstage passes")
                    => new BackstagePassUpdater(item),

                var name when SmellyItems.Contains(name)
                    => new SmellyItemUpdater(item),

                _ => new NormalItemUpdater(item)
            };
        }
    }
}

