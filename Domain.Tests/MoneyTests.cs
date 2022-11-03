namespace Domain.Tests
{
    using FluentAssertions;
    using Xunit;

    public class MoneyTests
    {
        [Fact]
        public void Sum_of_two_moneys_produces_correct_result()
        {
            // Arrange
            var money1 = new Money(
                oneCentCount: 1,
                tenCentCount: 2,
                quarterCount: 3,
                oneEuroCount: 4,
                fiveEuroCount: 5,
                twentyEuroCount: 6);

            var money2 = new Money(
                oneCentCount: 1,
                tenCentCount: 2,
                quarterCount: 3,
                oneEuroCount: 4,
                fiveEuroCount: 5,
                twentyEuroCount: 6);

            // Act
            var result = money1 + money2;

            // Assert
            result
                .OneCentCount
                .Should()
                .Be(2);

            result
                .TenCentCount
                .Should()
                .Be(4);

            result
                .QuarterCount
                .Should()
                .Be(6);

            result
                .OneEuroCount
                .Should()
                .Be(8);

            result
                .FiveEuroCount
                .Should()
                .Be(10);

            result
                .TwentyEuroCount
                .Should()
                .Be(12);
        }

        public void Two_money_instances_do_not_equal_if_contain_different_money_amount()
        {
        }

        [Fact]
        public void Two_money_instances_equal_if_contain_the_same_money_amount()
        {
            // Arrange
            var money1 = new Money(
                oneCentCount: 1,
                tenCentCount: 2,
                quarterCount: 3,
                oneEuroCount: 4,
                fiveEuroCount: 5,
                twentyEuroCount: 6);

            var money2 = new Money(
                oneCentCount: 1,
                tenCentCount: 2,
                quarterCount: 3,
                oneEuroCount: 4,
                fiveEuroCount: 5,
                twentyEuroCount: 6);

            // Act

            // Assert
            money1
                .Should()
                .Be(money2);

            money1
                .GetHashCode()
                .Should()
                .Be(money2.GetHashCode());
        }
    }
}