using System.Text;

using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        private const string StandardItemName = "An item";

        private const string LegendaryItemName = "Sulfuras, Hand of Ragnaros";

        private const string AgedBrieItemName = "Aged Brie";

        private const string BackstagePassItemName = "Backstage passes to a TAFKAL80ETC concert";

        private const string ConjureItemName = "Conjured Mana Cake";

        private ScenarioBuilder ForStandardItem()
        {
            return new ScenarioBuilder(StandardItemName);
        }

        private ScenarioBuilder ForLegendaryItem()
        {
            return new ScenarioBuilder(LegendaryItemName);
        }

        private ScenarioBuilder ForAgedBrieItem()
        {
            return new ScenarioBuilder(AgedBrieItemName);
        }

        private ScenarioBuilder ForBackstagePassItem()
        {
            return new ScenarioBuilder(BackstagePassItemName);
        }

        private ScenarioBuilder ForConjureItem()
        {
            return new ScenarioBuilder(ConjureItemName);
        }

        [Test]
        public void SellInReducesEachDayForStandardItems()
        {
            ForStandardItem()
                .When()
                .UpdatingQuality()
                .Should()
                .HaveDecreasedSellInBy(1);
        }

        [Test]
        public void SellInIsAlways0ForLegendaryItems()
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
        public void QualityReducesEachDayForStandardItems()
        {
            ForStandardItem()
                .When()
                .UpdatingQuality()
                .Should()
                .HaveDecreasedQualityBy(1);
        }

        [Test]
        public void QualityDegradesTwiceAsFastAfterSellInExpiresForStandardItems()
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

        [Test]
        public void QualityIncreasesEachDayForAgedBrie()
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

        [Test]
        public void QualityDoesNotChangeForLegendaryItems()
        {
            ForLegendaryItem()
                .WithAQualityValueOf(80)
                .WithASellInValueOf(10)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveNotChangedTheQualityValue();
        }

        [Test]
        public void QualityIncreasesByTwoForBackstagePassesWhenThereAre10DaysRemaining()
        {
            ForBackstagePassItem()
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(2);
        }

        [Test]
        public void QualityIncreasesByTwoForBackstagePassesWhenThereAre9DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(9)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(2);
        }

        [Test]
        public void QualityIncreasesByTwoForBackstagePassesWhenThereAre8DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(8)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(2);
        }

        [Test]
        public void QualityIncreasesByTwoForBackstagePassesWhenThereAre7DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(7)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(2);
        }

        [Test]
        public void QualityIncreasesByTwoForBackstagePassesWhenThereAre6DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(6)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(2);
        }

        [Test]
        public void QualityIncreasesByThreeForBackstagePassesWhenThereAre5DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(5)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(3);
        }

        [Test]
        public void QualityIncreasesByThreeForBackstagePassesWhenThereAre4DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(4)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(3);
        }

        [Test]
        public void QualityIncreasesByThreeForBackstagePassesWhenThereAre3DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(3)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(3);
        }

        [Test]
        public void QualityIncreasesByThreeForBackstagePassesWhenThereAre2DaysRemaining()
        {
            ForBackstagePassItem()
                .WithASellInValueOf(2)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveIncreasedQualityBy(3);
        }

        [Test]
        public void QualityIncreasesByThreeForBackstagePassesWhenThereIs1DayRemaining()
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

        [Test]
        public void ConjureItemsDegradeBy2EachDay()
        {
            ForConjureItem()
                .When()
                .UpdatingQuality()
                .Should()
                .HaveDecreasedQualityBy(2);
        }

        [Test]
        public void ConjureItemsDegradeBy4EachDayAfterExpiry()
        {
            ForConjureItem()
                .WithASellInValueOf(0)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveDecreasedQualityBy(4);
        }
    }
}