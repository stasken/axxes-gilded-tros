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
            CheckAfterSellInDecreased();
            FinalCheckQuality();
        }

        protected virtual void UpdateSellIn() => Item.SellIn--;

        protected abstract void UpdateQuality();

        protected virtual void CheckAfterSellInDecreased() { }

        protected virtual void FinalCheckQuality()
        {
            if (Item.Quality < 0) Item.Quality = 0;
            if (Item.Quality > 50) Item.Quality = 50;
        }

        protected void DecreaseQuality(int amount = 1)
        {
            Item.Quality -= amount;
        }

        protected void IncreaseQuality(int amount = 1)
        {
            Item.Quality += amount;
        }
    }
}

