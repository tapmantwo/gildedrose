namespace GildedRose.Console
{
    internal class QualityAdjuster
    {
        private readonly Item _item;

        public QualityAdjuster(Item item)
        {
            _item = item;
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
    }
}