namespace GildedRose.Console
{
    internal interface IItemProcessor
    {
        bool HandlesThisTypeOfItem(Item item);

        void DayHasPassed(AdjustableItem item);
    }
}