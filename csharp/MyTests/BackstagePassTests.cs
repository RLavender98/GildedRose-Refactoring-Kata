using System.Collections.Generic;
using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class BackstagePassTests
    {
        [Test]
        public void BackStage_Passes_Increase_In_Quality_By_One_When_Sell_By_More_Than_Ten_Days()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 3}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(4, Items[0].Quality);
        }
        
        [Test]
        public void BackStage_Passes_Increase_In_Quality_By_Two_When_Sell_By_Between_Six_and_Ten()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 3},new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 10}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(5, Items[0].Quality);
            Assert.AreEqual(12, Items[1].Quality);
        }
        
        [Test]
        public void BackStage_Passes_Increase_In_Quality_By_Three_When_Sell_By_Between_One_and_Five()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 3},new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 10}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(6, Items[0].Quality);
            Assert.AreEqual(13, Items[1].Quality);
        }
        
        [Test]
        public void BackStage_Passes_Are_Worth_Nothing_After_Concert()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 35},new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -5, Quality = 0}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
            Assert.AreEqual(0, Items[1].Quality);
        }
        
        [Test]
        public void Quality_Of_BackStage_Passes_Never_Exceeds_Fifty()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 49}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
        }
    }
}