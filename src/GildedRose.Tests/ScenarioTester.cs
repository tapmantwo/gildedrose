using GildedRose.Console;

using NUnit.Framework;

namespace GildedRose.Tests
{
    internal class ScenarioTester
    {
        private readonly Item _item;
        private readonly int _originalQuality;
        private readonly int _originalSellin;

        public ScenarioTester(Scenario runner)
        {
            _item = runner.Item;
            _originalQuality = runner.OriginalQuality;
            _originalSellin = runner.OriginalSellIn;
        }

        public ScenarioTester HaveIncreasedSellInBy(int increasedBy)
        {
            Assert.That(_item.SellIn, Is.EqualTo(_originalSellin + increasedBy));
            return this;
        }

        public ScenarioTester HaveDecreasedSellInBy(int decreaseddBy)
        {
            Assert.That(_item.SellIn, Is.EqualTo(_originalSellin - decreaseddBy));
            return this;
        }

        public ScenarioTester HaveASellInValueOf(int value)
        {
            Assert.That(_item.SellIn, Is.EqualTo(value));
            return this;
        }

        public ScenarioTester HaveNotChangedTheSellInValue()
        {
            Assert.That(_item.SellIn, Is.EqualTo(_originalSellin));
            return this;
        }

        public ScenarioTester HaveIncreasedQualityBy(int increasedBy)
        {
            Assert.That(_item.Quality, Is.EqualTo(_originalQuality + increasedBy));
            return this;
        }

        public ScenarioTester HaveDecreasedQualityBy(int decreaseddBy)
        {
            Assert.That(_item.Quality, Is.EqualTo(_originalQuality - decreaseddBy));
            return this;
        }

        public ScenarioTester HaveAQualityValueOf(int value)
        {
            Assert.That(_item.Quality, Is.EqualTo(value));
            return this;
        }

        public ScenarioTester HaveNotChangedTheQualityValue()
        {
            Assert.That(_item.Quality, Is.EqualTo(_originalQuality));
            return this;
        }
    }
}