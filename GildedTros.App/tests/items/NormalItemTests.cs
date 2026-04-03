using System;
using System.Collections.Generic;
using Xunit;

namespace GildedTros.App
{
    public class NormalItemTests
    {
        [Fact]
        public void Quality_Decreases_By_One_Before_SellDate()
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = "Normal Item", SellIn = 10, Quality = 20 }
        });

            app.UpdateQuality();

            Assert.Equal(9, app.Items[0].SellIn);
            Assert.Equal(19, app.Items[0].Quality);
        }

        [Fact]
        public void Quality_Decreases_Twice_As_Fast_After_SellDate()
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = "Normal Item", SellIn = 0, Quality = 20 }
        });

            app.UpdateQuality();

            Assert.Equal(-1, app.Items[0].SellIn);
            Assert.Equal(18, app.Items[0].Quality);
        }

        [Fact]
        public void Quality_Never_Goes_Below_Zero()
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = "Normal Item", SellIn = 5, Quality = 0 }
        });

            app.UpdateQuality();

            Assert.Equal(0, app.Items[0].Quality);
        }
    }

}

