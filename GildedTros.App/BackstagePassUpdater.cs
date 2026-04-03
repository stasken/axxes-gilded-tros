using System;
namespace GildedTros.App
{
	public class BackstagePassUpdater : ItemUpdater
	{
        public BackstagePassUpdater(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            IncreaseQuality();
            if (Item.SellIn <= 10)
                IncreaseQuality();
            if (Item.SellIn <= 5)
                IncreaseQuality();
        }

    }
}

