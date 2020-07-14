namespace csharp
{
    public class AgedBrieUpdater:ItemUpdater
    {
        public override void UpdateItem(Item item)
        {
            if (item.Quality < 50)
                item.Quality += 1;
            if (item.SellIn <= 0 && item.Quality < 50)
                item.Quality += 1;
            item.SellIn -= 1;
        }
    }
}