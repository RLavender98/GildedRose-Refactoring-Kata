using System;

namespace csharp
{
    public class BackstagePassUpdater:ItemUpdater
    {
        public override void UpdateItem(Item item)
        {
            if (item.SellIn > 0 && item.Quality < 50)
                item.Quality += 1;
            if (item.SellIn <= 10 && item.Quality < 50)
                item.Quality += 1;
            if (item.SellIn <= 5 && item.Quality < 50)
                item.Quality += 1;
            if (item.SellIn <= 0)
                item.Quality = 0;
            item.SellIn -= 1;
        }
    }
}