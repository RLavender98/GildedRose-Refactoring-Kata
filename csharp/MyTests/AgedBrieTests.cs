using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class AgedBrieTests
    {
        [Test]
        public void Aged_Brie_Increases_In_Quality_As_It_Gets_Older()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 8, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(6, Items[0].Quality);
        }
        
        [Test]
        public void Aged_Brie_Increases_In_Quality_Twice_As_Fast_After_Sell_By_Date()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0-2, Quality = 6} };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(8, Items[0].Quality);
        }
        
        [Test]
        public void Quality_Of_Aged_Brie_Never_Exceeds_Fifty()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -2, Quality = 49}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
        }
    }
}