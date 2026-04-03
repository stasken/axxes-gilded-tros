using System;
using System.Collections.Generic;
using Xunit;

namespace GildedTros.App
{
    public class GoodWineTests
    {
        [Fact]
        public void GoodWine_Increases_In_Quality()
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = "Good Wine", SellIn = 10, Quality = 10 }
        });

            app.UpdateQuality();

            Assert.Equal(11, app.Items[0].Quality);
        }

        [Fact]
        public void GoodWine_Increases_Twice_As_Fast_After_SellDate()
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = "Good Wine", SellIn = 0, Quality = 10 }
        });

            app.UpdateQuality();

            Assert.Equal(12, app.Items[0].Quality);
        }

        [Fact]
        public void GoodWine_Quality_Never_Exceeds_50()
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = "Good Wine", SellIn = 5, Quality = 50 }
        });

            app.UpdateQuality();

            Assert.Equal(50, app.Items[0].Quality);
        }
    }

}

