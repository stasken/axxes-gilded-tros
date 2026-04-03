using System;
using System.Collections.Generic;
using Xunit;

namespace GildedTros.App
{
    public class BackstagePassTests
    {
        [Fact]
        public void BackstagePass_Increases_By_1_When_More_Than_10_Days()
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = "Backstage passes", SellIn = 15, Quality = 20 }
        });

            app.UpdateQuality();

            Assert.Equal(21, app.Items[0].Quality);
        }

        [Fact]
        public void BackstagePass_Increases_By_2_When_10_Days_Or_Less()
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = "Backstage passes", SellIn = 10, Quality = 20 }
        });

            app.UpdateQuality();

            Assert.Equal(22, app.Items[0].Quality);
        }

        [Fact]
        public void BackstagePass_Increases_By_3_When_5_Days_Or_Less()
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = "Backstage passes", SellIn = 5, Quality = 20 }
        });

            app.UpdateQuality();

            Assert.Equal(23, app.Items[0].Quality);
        }

        [Fact]
        public void BackstagePass_Quality_Drops_To_Zero_After_Concert()
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = "Backstage passes", SellIn = 0, Quality = 20 }
        });

            app.UpdateQuality();

            Assert.Equal(0, app.Items[0].Quality);
        }

        [Fact]
        public void BackstagePass_Quality_Never_Exceeds_50()
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = "Backstage passes", SellIn = 5, Quality = 50 }
        });

            app.UpdateQuality();

            Assert.Equal(50, app.Items[0].Quality);
        }
    }

}

