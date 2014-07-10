using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class ConjureTests
    {
        private const string ConjureItemName = "Conjured Mana Cake";

        private ScenarioBuilder ForConjureItem()
        {
            return new ScenarioBuilder(ConjureItemName);
        }

        [Test]
        public void QualityDegradeBy2EachDay()
        {
            ForConjureItem()
                .When()
                .UpdatingQuality()
                .Should()
                .HaveDecreasedQualityBy(2);
        }

        [Test]
        public void QualityDegradeBy4EachDayAfterExpiry()
        {
            ForConjureItem()
                .WithASellInValueOf(0)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveDecreasedQualityBy(4);
        }

        [Test]
        public void QualityDoesNotGoBelowZero()
        {
            ForConjureItem()
                .WithASellInValueOf(0)
                .WithAQualityValueOf(0)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveNotChangedTheQualityValue();            
        }

        [Test]
        public void SellInDecrements()
        {
            ForConjureItem()
                .WithASellInValueOf(1)
                .When()
                .UpdatingQuality()
                .Should()
                .HaveDecreasedSellInBy(1);
        }
    }
}