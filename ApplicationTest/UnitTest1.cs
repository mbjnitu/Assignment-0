namespace ApplicationTest;

public class ProgramTests
{
    [Fact]
    public void Main_when_run_prints_Hello_World()
    {
        // Arrange
        var sut = new HelloWorld();

        // Act
        var result = sut.run();

        // Assert
        result.Should().Be("Hello, World!");
    }
}