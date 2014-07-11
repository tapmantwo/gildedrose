namespace GildedRose.Console
{
    internal class DefaultItemProcessor : IItemProcessor
    {
        public bool HandlesThisTypeOfItem(Item item)
        {
            var typeInferrer = new ItemTypeInferrer(item);
            return typeInferrer.IsDefaultItem();
        }

        public void DayHasPassed(AdjustableItem item)
        {
            item.DecrementSellIn();

            var qualityAdjustment = item.SellIn < 0 ? 2 : 1;

            item.DecrementQuality(qualityAdjustment);
        }
    }
}