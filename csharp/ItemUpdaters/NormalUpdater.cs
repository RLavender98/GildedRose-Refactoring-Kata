namespace csharp
{
    public class NormalUpdater:ItemUpdater
    {
        public override void UpdateItem(Item item)
        {
            if (item.Quality > 0)
                item.Quality -= 1;
            if (item.SellIn <= 0 && item.Quality > 0)
                item.Quality -= 1;
            item.SellIn -= 1;
        }
    }
}