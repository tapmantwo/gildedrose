using System.Text;

using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class AgedBrieTests
    {
        private ScenarioBuilder ForAgedBrieItem()
        {
            return new ScenarioBuilder("Aged Brie");
        }

        [Test]
        public void QualityIncreasesEachDay()
        {
            ForAgedBrieItem()
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(1);
        }

        [Test]
        public void QualityNeverIncreasesAbove50()
        {
            ForAgedBrieItem()
                .WithAQualityValueOf(50)
                .WithASellInValueOf(10)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveNotChangedTheQualityValue();
        }
    }
}