namespace GildedRose.Console
{
    internal class BackstagePassItemProcessor : IItemProcessor
    {
        public bool HandlesThisTypeOfItem(Item item)
        {
            var typeInferrer = new ItemTypeInferrer(item);
            return typeInferrer.IsBackstagePass();
        }

        public void DayHasPassed(AdjustableItem item)
        {
            item.DecrementSellIn();

            if (item.SellIn < 0)
            {
                item.SetQualityToZero();
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

                item.IncrementQuality(qualityAdjustment);
            }
        }
    }
}