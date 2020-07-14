namespace csharp
{
    public class ConjuredUpdater:IItemUpdater
    {
        public void UpdateItem(Item item)
        {
            foreach (int dummy in new[] {1, 2})
            {
                if (item.Quality > 0)
                    item.Quality -= 1;
                if (item.SellIn <= 0 &&item.Quality > 0)
                    item.Quality -= 1;
            }
            item.SellIn -= 1;
        }
    }
}