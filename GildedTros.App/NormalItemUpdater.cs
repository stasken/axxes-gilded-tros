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

    }
}

