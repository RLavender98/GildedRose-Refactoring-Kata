using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                ItemUpdater itemUpdater = null;
                if (Items[i].Name == "Aged Brie")
                    itemUpdater = new AgedBrieUpdater();
                else if (Items[i].Name == "Sulfuras, Hand of Ragnaros")
                    itemUpdater = new SulfurasUpdater();
                else if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                    itemUpdater = new BackstagePassUpdater();
                else if (Items[i].Name == "Conjured Mana Cake")
                    itemUpdater = new ConjuredUpdater();
                else
                    itemUpdater = new NormalUpdater();
                itemUpdater.UpdateItem(Items[i]);
            }
        }
    }
}
