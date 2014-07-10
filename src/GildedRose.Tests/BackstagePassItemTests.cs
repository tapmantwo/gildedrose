using System.Text;

using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class BackstagePassItemTests
    {
        private ScenarioBuilder ForBackstagePassItem()
        {
            return new ScenarioBuilder("Backstage passes to a TAFKAL80ETC concert");
        }

        [Test]
        public void QualityIncreasesByTwoWhenThereAre10DaysRemaining()
        {
            ForBackstagePassItem()
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(2);
        }

        [Test]
        public void QualityIncreasesByTwoWhenThereAre9DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(9)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(2);
        }

        [Test]
        public void QualityIncreasesByTwoWhenThereAre8DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(8)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(2);
        }

        [Test]
        public void QualityIncreasesByTwoWhenThereAre7DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(7)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(2);
        }

        [Test]
        public void QualityIncreasesByTwoWhenThereAre6DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(6)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(2);
        }

        [Test]
        public void QualityIncreasesByThreeWhenThereAre5DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(5)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(3);
        }

        [Test]
        public void QualityIncreasesByThreeWhenThereAre4DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(4)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(3);
        }

        [Test]
        public void QualityIncreasesByThreeWhenThereAre3DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(3)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(3);
        }

        [Test]
        public void QualityIncreasesByThreeWhenThereAre2DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(2)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(3);
        }

        [Test]
        public void QualityIncreasesByThreeWhenThereIs1DayRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(1)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(3);
        }

        [Test]
        public void QualityIs0ForBackstagePassesWhenTheItemHasExpired()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(0)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveAQualityValueOf(0);
        }
    }
}