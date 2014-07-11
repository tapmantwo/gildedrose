namespace GildedRose.Console
{
    internal class LegendaryItemProcessor : IItemProcessor
    {
        public bool HandlesThisTypeOfItem(Item item)
        {
            var typeInferrer = new ItemTypeInferrer(item);
            return typeInferrer.IsLegendary();
        }

        public void DayHasPassed(AdjustableItem item)
        {
            // Do not alter the item
        }
    }
}