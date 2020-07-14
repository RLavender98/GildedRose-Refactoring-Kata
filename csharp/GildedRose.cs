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
                var itemUpdaterFactory = new ItemUpdaterFactory();
                var itemUpdater = itemUpdaterFactory.GetItemUpdater(Items[i]);
                itemUpdater.UpdateItem(Items[i]);
            }
        }
    }
}
