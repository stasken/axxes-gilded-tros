using System;
namespace GildedTros.App
{
	public class SmellyItemUpdater : ItemUpdater
	{
        public SmellyItemUpdater(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            DecreaseQuality(2);
        }

        protected override void CheckAfterSellInDecreased()
        {
            if (Item.SellIn < 0)
            {
                DecreaseQuality();
            }
        }
    }
}

