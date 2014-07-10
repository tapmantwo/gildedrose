using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class LegendaryItemTests
    {
        private ScenarioBuilder ForLegendaryItem()
        {
            return new ScenarioBuilder("Sulfuras, Hand of Ragnaros");
        }

        [Test]
        public void SellInIsAlways0()
        {
            ForLegendaryItem()
                .WithAQualityValueOf(80)
                .WithASellInValueOf(0)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveNotChangedTheSellInValue();
        }

        [Test]
        public void QualityDoesNotChange()
        {
            ForLegendaryItem()
                .WithAQualityValueOf(80)
                .WithASellInValueOf(10)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveNotChangedTheQualityValue();
        }
    }
}