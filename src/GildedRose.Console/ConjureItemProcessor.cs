namespace GildedRose.Console
{
    internal class ConjureItemProcessor : IItemProcessor
    {
        public bool HandlesThisTypeOfItem(Item item)
        {
            var itemInferrer = new ItemTypeInferrer(item);
            return itemInferrer.IsConjure();
        }

        public void DayHasPassed(Item item)
        {
            var sellInAdjuster = new SellInAdjuster(item);
            sellInAdjuster.DecrementSellIn();

            var qualityAdjustment = item.SellIn < 0 ? 4 : 2;

            var qualityAdjuster = new QualityAdjuster(item);
            qualityAdjuster.DecrementQuality(qualityAdjustment);
        }
    }
}