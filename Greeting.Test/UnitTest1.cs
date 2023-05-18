namespace Greeting.Test;

public class GreetingTest
{
    private readonly Greeting _sut;

    public GreetingTest()
    {
        _sut = new Greeting();
    }

    [Fact]
    public void SimpleGreet()
    {
        Assert.True(true);
    }

    [Fact]
    public void ShouldReturnGreetPerson()
    {
        Assert.Equal("Hello, Bob", _sut.Greet("Bob"));
    }

    [Fact]
    public void ShouldReturnGreetNullPerson()
    {
        Assert.Equal("Hello, my friend", _sut.Greet(null));
    }
}
