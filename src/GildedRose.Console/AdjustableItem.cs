namespace GildedRose.Console
{
    public class AdjustableItem
    {
        private readonly Item _item;

        public AdjustableItem(Item item)
        {
            _item = item;
        }

        public int SellIn
        {
            get
            {
                return _item.SellIn;
            }
        }

        public void SetQualityToZero()
        {
            _item.Quality = 0;
        }

        public void IncrementQuality(int by)
        {
            _item.Quality += by;
            if (_item.Quality > 50)
            {
                _item.Quality = 50;
            }
        }

        public void DecrementQuality(int by)
        {
            _item.Quality -= by;

            if (_item.Quality < 0)
            {
                _item.Quality = 0;
            }
        }

        public void DecrementSellIn()
        {
            _item.SellIn--;            
        }
    }
}