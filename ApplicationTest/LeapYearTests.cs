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

    [Fact]
    public void CheckNumberDivisibleBy400()
    {
        // Arrange
        var ly = new LeapYear();

        // Act
        var result1 = ly.IsDivBy400(400);
        var result2 = ly.IsDivBy400(302400);
        var result3 = ly.IsDivBy400(300);
        var result4 = ly.IsDivBy400(1000);

        // Assert
        result1.Should().Be(true);
        result2.Should().Be(true);
        result3.Should().Be(false);
        result4.Should().Be(false);
    }

    [Fact] // Test is based on "https://www.calendar.best/leap-years.html"
    public void CheckIfNumberIsALeapYear()
    {
        // Arrange
        var ly = new LeapYear();

        // Act
        var result1 = ly.IsLeapYear(1904);
        var result2 = ly.IsLeapYear(2976);
        var result3 = ly.IsLeapYear(2780);
        
        var result4 = ly.IsLeapYear(1900);
        var result5 = ly.IsLeapYear(2600);
        var result6 = ly.IsLeapYear(3000);

        // Assert
        result1.Should().Be(true);
        result2.Should().Be(true);
        result3.Should().Be(true);

        result4.Should().Be(false);
        result5.Should().Be(false);
        result6.Should().Be(false);
    }

    [Fact]
    public void NonIntConvertableShouldReturnFalse()
    {
        // Arrange
        var ly = new LeapYear();

        // Act
        var result1 = ly.IsLeapYear("hello");
        var result2 = ly.IsLeapYear("2000");

        // Assert
        result1.Should().Be(false);
        result2.Should().Be(true);
    }

    [Fact]
    public void AllYearsBefore1582ShouldReturnFalse()
    {
        // Arrange
        var ly = new LeapYear();

        // Act
        var result1 = ly.IsLeapYear("32");
        var result2 = ly.IsLeapYear(32);
        var result3 = ly.IsLeapYear("1504");
        var result4 = ly.IsLeapYear(1504);
        var result5 = ly.IsLeapYear("800");
        var result6 = ly.IsLeapYear(800);

        // Assert
        result1.Should().Be(false);
        result2.Should().Be(false);
        result3.Should().Be(false);
        result4.Should().Be(false);
        result5.Should().Be(false);
        result6.Should().Be(false);
    }
}