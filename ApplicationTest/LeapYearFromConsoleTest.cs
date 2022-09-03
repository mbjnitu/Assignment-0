namespace ApplicationTest;

public class LeapYearFromConsoleTest
{
    [Fact]
    public void CheckLeapYear()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        using var reader = new StringReader("2000");
        Console.SetIn(reader);

        // Act
        // No idea how to run the program from a test, giving it 2000, and checking if i recieve yay.

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        //output.Should().Be("yay");
    }
}