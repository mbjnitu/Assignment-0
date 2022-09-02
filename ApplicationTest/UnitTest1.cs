namespace ApplicationTest;

public class ProgramTests
{
    [Fact]
    public void Main_when_run_prints_Hello_World()
    {
        // Arrange
        var hw = new Program.HelloWorld();

        // Act
        var result = hw.run();

        // Assert
        result.Should().Be("Hello, World!");
    }
}