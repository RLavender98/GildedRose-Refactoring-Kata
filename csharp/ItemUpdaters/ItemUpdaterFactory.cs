using System.Reflection;

namespace csharp
{
    public class ItemUpdaterFactory
    {
        public IItemUpdater GetItemUpdater(Item item)
        {
            IItemUpdater itemUpdater = null;
            if (item.Name == "Aged Brie")
                itemUpdater = new AgedBrieUpdater();
            else if (item.Name == "Sulfuras, Hand of Ragnaros")
                itemUpdater = new SulfurasUpdater();
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                itemUpdater = new BackstagePassUpdater();
            else if (item.Name == "Conjured Mana Cake")
                itemUpdater = new ConjuredUpdater();
            else
                itemUpdater = new NormalUpdater();
            return itemUpdater;
        }
    }
}