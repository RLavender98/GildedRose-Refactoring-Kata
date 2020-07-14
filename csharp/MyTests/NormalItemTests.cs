using NUnit.Framework;
using System.Collections.Generic;
using System.Reflection;

namespace csharp
{
    [TestFixture]
    public class NormalItemTests
    {
        [Test]
        public void After_Sell_By_Date_Quality_Reduces_Twice_As_Fast()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(8, Items[0].Quality);
        }

        [Test]
        public void Quality_Of_Item_Is_Never_Negative()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 8, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }
    }
}