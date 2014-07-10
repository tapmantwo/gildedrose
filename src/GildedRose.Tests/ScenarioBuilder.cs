using GildedRose.Console;

namespace GildedRose.Tests
{
    internal class ScenarioBuilder
    {
        private readonly string _name;
        private int _sellIn;
        private int _quality;

        public ScenarioBuilder(string name)
        {
            _name = name;
            _sellIn = 10;
            _quality = 10;
        }

        public ScenarioBuilder WithASellInValueOf(int sellIn)
        {
            _sellIn = sellIn;

            return this;
        }

        public ScenarioBuilder WithAQualityValueOf(int quality)
        {
            _quality = quality;

            return this;
        }

        public Scenario When()
        {
            return new Scenario(this);
        }

        public Item BuildItem()
        {
            return new Item { Name = _name, Quality = _quality, SellIn = _sellIn };
        }
    }
}