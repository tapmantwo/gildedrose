using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class StandardItemTests
    {
        private ScenarioBuilder ForStandardItem()
        {
            return new ScenarioBuilder("An item");
        }

        [Test]
        public void SellInReducesEachDay()
        {
            ForStandardItem()
                .When()
                .UpdatingQuality()
                .Should()
                .HaveDecreasedSellInBy(1);
        }
        
        [Test]
        public void QualityReducesEachDay()
        {
            ForStandardItem()
                .When()
                .UpdatingQuality()
                .Should()
                .HaveDecreasedQualityBy(1);
        }

        [Test]
        public void QualityDegradesTwiceAsFastAfterSellInExpires()
        {
            ForStandardItem()
                .WithASellInValueOf(0)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveDecreasedQualityBy(2);
        }

        [Test]
        public void QualityIsNeverNegative()
        {
            ForStandardItem()
                .WithAQualityValueOf(0)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveNotChangedTheQualityValue();
        }
    }
}