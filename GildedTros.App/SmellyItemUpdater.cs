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

    }
}

