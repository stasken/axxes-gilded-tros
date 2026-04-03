using System;
using System.Collections.Generic;
using Xunit;

namespace GildedTros.App
{
    public class LegendaryItemTests
    {
        [Fact]
        public void LegendaryItem_Quality_Is_Always_80()
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = "B-DAWG Keychain", SellIn = 10, Quality = 80 }
        });

            app.UpdateQuality();

            Assert.Equal(80, app.Items[0].Quality);
        }

        [Fact]
        public void LegendaryItem_SellIn_Does_Not_Change()
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = "B-DAWG Keychain", SellIn = 10, Quality = 80 }
        });

            app.UpdateQuality();

            Assert.Equal(10, app.Items[0].SellIn);
        }
    }

}

