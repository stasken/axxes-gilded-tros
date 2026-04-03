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

    }
}

