namespace GildedRose.Console
{
    internal class ConjureItemProcessor : IItemProcessor
    {
        public bool HandlesThisTypeOfItem(Item item)
        {
            var itemInferrer = new ItemTypeInferrer(item);
            return itemInferrer.IsConjure();
        }

        public void DayHasPassed(AdjustableItem item)
        {
            item.DecrementSellIn();

            var qualityAdjustment = item.SellIn < 0 ? 4 : 2;

            item.DecrementQuality(qualityAdjustment);
        }
    }
}