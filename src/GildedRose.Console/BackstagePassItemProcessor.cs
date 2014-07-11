namespace GildedRose.Console
{
    internal class BackstagePassItemProcessor : IItemProcessor
    {
        public bool HandlesThisTypeOfItem(Item item)
        {
            var typeInferrer = new ItemTypeInferrer(item);
            return typeInferrer.IsBackstagePass();
        }

        public void DayHasPassed(Item item)
        {
            var sellInAdjuster = new SellInAdjuster(item);
            sellInAdjuster.DecrementSellIn();

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else
            {
                var qualityAdjustment = 0;
                if (item.SellIn < 5)
                {
                    qualityAdjustment = 3;
                }
                else if (item.SellIn < 10)
                {
                    qualityAdjustment = 2;
                }
                else
                {
                    qualityAdjustment = 1;
                }

                var qualityAdjuster = new QualityAdjuster(item);
                qualityAdjuster.IncrementQuality(qualityAdjustment);
            }
        }
    }
}