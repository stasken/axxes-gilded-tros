using System;
namespace GildedTros.App
{
	public class LegendaryItemUpdater : ItemUpdater
	{
        public LegendaryItemUpdater(Item item) : base(item) { }

        protected override void UpdateQuality() { }

        protected override void UpdateSellIn() { }

        protected override void CheckAfterSellInDecreased() { }

        protected override void FinalCheckQuality() { }
    }
}

