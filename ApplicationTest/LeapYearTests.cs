namespace ApplicationTest;

public class LeapYearTests
{
    [Fact]
    public void CheckNumberDivisibleBy4()
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
    
    [Fact]
    public void CheckNumberDivisibleBy100()
    {
        // Arrange
        var ly = new LeapYear();

        // Act
        var result1 = ly.IsDivBy100(50);
        var result2 = ly.IsDivBy100(100);
        var result3 = ly.IsDivBy100(90000100);
        var result4 = ly.IsDivBy100(1090);

        // Assert
        result1.Should().Be(false);
        result2.Should().Be(true);
        result3.Should().Be(true);
        result4.Should().Be(false);
    }
}