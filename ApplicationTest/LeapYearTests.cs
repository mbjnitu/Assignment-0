namespace ApplicationTest;

public class LeapYearTests
{
    [Fact]
    public void CheckNumberDivisibleByFour()
    {
        // Arrange
        var ly = new LeapYear();

        // Act
        var result1 = ly.IsDivBy4(4);
        var result2 = ly.IsDivBy4(8);
        var result3 = ly.IsDivBy4(304);
        var result4 = ly.IsDivBy4(38108);

        // Assert
        result1.Should().Be(true);
        result2.Should().Be(true);
        result3.Should().Be(true);
        result4.Should().Be(true);
    }
}