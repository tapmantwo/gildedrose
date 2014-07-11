namespace GildedRose.Console
{
    internal class AgedBrieItemProcessor : IItemProcessor
    {
        public bool HandlesThisTypeOfItem(Item item)
        {
            var typeInferrer = new ItemTypeInferrer(item);
            return typeInferrer.IsAgedBrie();
        }

        public void DayHasPassed(AdjustableItem item)
        {
            item.DecrementSellIn();

            var qualityAdjustment = item.SellIn < 0 ? 2 : 1;
            item.IncrementQuality(qualityAdjustment);
        }
    }
}