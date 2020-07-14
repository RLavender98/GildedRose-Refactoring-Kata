namespace csharp
{
    public class AgedBrieUpdater:IItemUpdater
    {
        public void UpdateItem(Item item)
        {
            if (item.Quality < 50)
                item.Quality += 1;
            if (item.SellIn <= 0 && item.Quality < 50)
                item.Quality += 1;
            item.SellIn -= 1;
        }
    }
}