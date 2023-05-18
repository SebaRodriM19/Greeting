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

    [Fact]
    public void ShouldReturnGreetShouted()
    {
        Assert.Equal("HELLO BOB!", _sut.ShoutedGreet("BOB"));
    }

    [Fact]
    [InlineData(2, new[] { "Jill", "Jane" })]
    public void ShouldGreetTwoPerson()
    {
        Assert.Equal("Hello, Jill and Jane", _sut.GreetTwoPerson("Jill", "Jane"));
    }

    [Fact]
    [InlineData(3,new[] { "Amy", "Brian", "Charlotte" })]
    public void ShouldGreetMorePerson()
    {
        Assert.Equal("Hello, Amy, Brian, and Charlotte.", _sut.GreetMorePerson("Amy", "Brian", "Charlotte"));
    }
}
