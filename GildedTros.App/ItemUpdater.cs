using System;
namespace GildedTros.App
{
	public abstract class ItemUpdater
	{
		protected readonly Item Item;

		protected ItemUpdater(Item item)
		{
			Item = item;
		}

		public void Update()
		{
			UpdateQuality();
			UpdateSellIn();
        }

        protected virtual void UpdateSellIn() => Item.SellIn--;

        protected abstract void UpdateQuality();

    }
}

