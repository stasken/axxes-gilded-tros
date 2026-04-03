using System;
namespace GildedTros.App
{
	public class GoodWineUpdater : ItemUpdater
	{
        public GoodWineUpdater(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            IncreaseQuality();
        }

        protected override void CheckAfterSellInDecreased()
        {
            if (Item.SellIn < 0)
            {
                IncreaseQuality();
            }
        }
    }
}

