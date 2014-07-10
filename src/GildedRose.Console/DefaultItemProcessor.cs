namespace GildedRose.Console
{
    internal class DefaultItemProcessor : IItemProcessor
    {
        public bool HandlesThisTypeOfItem(Item item)
        {
            var typeInferrer = new ItemTypeInferrer(item);
            return typeInferrer.IsDefaultItem();
        }

        public void DayHasPassed(Item item)
        {
            var sellInAdjuster = new SellInAdjuster(item);
            sellInAdjuster.DecrementSellIn();

            var qualityAdjustment = item.SellIn < 0 ? 2 : 1;

            var qualityAdjuster = new QualityAdjuster(item);
            qualityAdjuster.DecrementQuality(qualityAdjustment);
        }
    }
}