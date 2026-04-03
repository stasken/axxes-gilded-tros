using System;
using System.Collections.Generic;
using Xunit;

namespace GildedTros.App
{
    public class SmellyItemTests
    {
        [Theory]
        [InlineData("Duplicate Code")]
        [InlineData("Long Methods")]
        [InlineData("Ugly Variable Names")]
        public void SmellyItems_Degrade_Twice_As_Fast(string itemName)
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = itemName, SellIn = 10, Quality = 20 }
        });

            app.UpdateQuality();

            Assert.Equal(18, app.Items[0].Quality);
        }

        [Theory]
        [InlineData("Duplicate Code")]
        [InlineData("Long Methods")]
        [InlineData("Ugly Variable Names")]
        public void SmellyItems_Degrade_Four_Times_As_Fast_After_SellDate(string itemName)
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = itemName, SellIn = 0, Quality = 20 }
        });

            app.UpdateQuality();

            Assert.Equal(16, app.Items[0].Quality);
        }

        [Theory]
        [InlineData("Duplicate Code")]
        [InlineData("Long Methods")]
        [InlineData("Ugly Variable Names")]
        public void SmellyItems_Quality_Never_Goes_Below_Zero(string itemName)
        {
            var app = new GildedTros(new List<Item> {
            new Item { Name = itemName, SellIn = 5, Quality = 0 }
        });

            app.UpdateQuality();

            Assert.Equal(0, app.Items[0].Quality);
        }
    }

}

