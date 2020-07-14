namespace csharp
{
    public class NormalUpdater:IItemUpdater
    {
        public void UpdateItem(Item item)
        {
            if (item.Quality > 0)
                item.Quality -= 1;
            if (item.SellIn <= 0 && item.Quality > 0)
                item.Quality -= 1;
            item.SellIn -= 1;
        }
    }
}