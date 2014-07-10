using GildedRose.Console;

namespace GildedRose.Tests
{
    internal class Scenario
    {
        private readonly Item _item;

        private readonly int _originalQuality;

        private readonly int _originalSellin;

        private readonly Program _program;

        public Scenario(ScenarioBuilder scenarioBuilder)
        {
            _program = new Program();

            _item = scenarioBuilder.BuildItem();
            _originalQuality = _item.Quality;
            _originalSellin = _item.SellIn;

            _program.SetItems(new[] { _item });
        }

        public int OriginalQuality
        {
            get
            {
                return _originalQuality;
            }
        }

        public int OriginalSellIn
        {
            get
            {
                return _originalSellin;
            }
        }

        public Item Item
        {
            get
            {
                return _item;
            }
        }

        public Scenario UpdatingQuality()
        {
            _program.UpdateQuality();
            return this;
        }

        public ScenarioTester Should()
        {
            return new ScenarioTester(this);
        }
    }
}