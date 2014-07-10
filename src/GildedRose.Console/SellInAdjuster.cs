namespace GildedRose.Console
{
    internal class SellInAdjuster
    {
        private readonly Item _item;

        public SellInAdjuster(Item item)
        {
            _item = item;
        }
        
        public void DecrementSellIn()
        {
            _item.SellIn--;
        }
    }
}