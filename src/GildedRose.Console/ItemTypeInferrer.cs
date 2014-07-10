namespace GildedRose.Console
{
    internal class ItemTypeInferrer
    {
        private readonly Item _item;

        public ItemTypeInferrer(Item item)
        {
            _item = item;
        }

        public bool IsAgedBrie()
        {
            return _item.Name == "Aged Brie";
        }

        public bool IsBackstagePass()
        {
            return _item.Name == "Backstage passes to a TAFKAL80ETC concert";
        }

        public bool IsLegendary()
        {
            return _item.Name == "Sulfuras, Hand of Ragnaros";
        }

        public bool IsConjure()
        {
            return _item.Name == "Conjured Mana Cake";
        }

        public bool IsDefaultItem()
        {
            if (IsAgedBrie())
            {
                return false;
            }

            if (IsBackstagePass())
            {
                return false;
            }

            if (IsLegendary())
            {
                return false;
            }

            if (IsConjure())
            {
                return false;
            }

            return true;
        }
    }
}