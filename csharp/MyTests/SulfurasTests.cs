using System.Collections.Generic;
using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class SulfurasTests
    {
        [Test]
        public void Sulfuras_Hand_Of_Ragnaros_Never_Changes_Quality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -2, Quality = 49}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(49, Items[0].Quality);
        }
        
        [Test]
        public void Sulfuras_Hand_Of_Ragnaros_Never_Changes_Sell_By_Date()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 8, Quality = 49}};
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(8, Items[0].SellIn);
        }
    }
}