using System;
namespace GildedTros.App
{
	public class NormalItemUpdater : ItemUpdater
	{
		public NormalItemUpdater(Item item) : base(item) { }

        protected override void UpdateQuality()
        {
            DecreaseQuality();
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

