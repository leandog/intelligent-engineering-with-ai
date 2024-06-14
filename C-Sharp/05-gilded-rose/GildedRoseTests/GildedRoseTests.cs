using System.Collections.Generic;
using Xunit;

namespace GildedRose
{
    public class GildedRoseTests
    {
        [Theory]
        [InlineData("Potion", 10, 10, 9, 9)]
        [InlineData("Potion", 0, 10, -1, 8)]
        [InlineData("Potion", -1, 0, -2, 0)]
        [InlineData("Potion", -1, -1, -2, -1)]
        [InlineData("Aged Brie", 5, 50, 4, 50)]
        [InlineData("Aged Brie", 2, 0, 1, 1)]
        [InlineData("Aged Brie", 0, 0, -1, 2)]
        [InlineData("Sulfuras, Hand of Ragnaros", 5, 50, 5, 50)]
        [InlineData("Sulfuras, Hand of Ragnaros", 0, 50, 0, 50)]
        [InlineData("Sulfuras, Hand of Ragnaros", -1, 50, -1, 50)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 0, 10, -1, 0)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 1, 10, 0, 13)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 15, 10, 14, 11)]
        public void TestAgedBrieQuality(
            string itemName,
            int initialSellIn,
            int initialQuality,
            int expectedSellIn,
            int expectedQuality
        )
        {
            AssertItem(itemName, initialSellIn, initialQuality, expectedSellIn, expectedQuality);
        }

        [Theory]
        [InlineData(5, 2, 4, 0)]
        [InlineData(0, 4, -1, 0)]
        [InlineData(0, 0, -1, 0)]
        public void TestConjuredItem(
            int initialSellIn,
            int initialQuality,
            int expectedSellIn,
            int expectedQuality
        )
        {
            AssertItem("Conjured", initialSellIn, initialQuality, expectedSellIn, expectedQuality);
        }

        private static void AssertItem(
            string itemName,
            int initialSellIn,
            int initialQuality,
            int expectedSellIn,
            int expectedQuality
        )
        {
            var items = new List<Item>
            {
                new()
                {
                    Name = itemName,
                    SellIn = initialSellIn,
                    Quality = initialQuality
                }
            };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(expectedSellIn, items[0].SellIn);
            Assert.Equal(expectedQuality, items[0].Quality);
        }
    }
}
