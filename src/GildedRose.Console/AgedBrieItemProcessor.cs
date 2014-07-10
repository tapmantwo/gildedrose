namespace GildedRose.Console
{
    internal class AgedBrieItemProcessor : IItemProcessor
    {
        public bool HandlesThisTypeOfItem(Item item)
        {
            var typeInferrer = new ItemTypeInferrer(item);
            return typeInferrer.IsAgedBrie();
        }

        public void DayHasPassed(Item item)
        {
            var sellInAdjuster = new SellInAdjuster(item);
            sellInAdjuster.DecrementSellIn(1);

            var qualityAdjustment = item.SellIn < 0 ? 2 : 1;

            var qualityAdjuster = new QualityAdjuster(item);
            qualityAdjuster.IncrementQuality(qualityAdjustment);
        }
    }
}