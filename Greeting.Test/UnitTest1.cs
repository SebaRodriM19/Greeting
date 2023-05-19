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
        Assert.Equal("Hello, Bob.", _sut.GreetMain("Bob"));
    }

    [Fact]
    public void ShouldReturnGreetNullPerson()
    {
        Assert.Equal("Hello, my friend.", _sut.GreetMain(null));
    }

    [Fact]
    public void ShouldReturnGreetShouted()
    {
        Assert.Equal("HELLO BOB!", _sut.GreetMain("BOB"));
    }

    [Fact]
    public void ShouldGreetTwoPerson()
    {
        Assert.Equal("Hello, Jill and Jane.", _sut.GreetMain("Jill", "Jane"));
    }

    [Fact]
    public void ShouldGreetMorePerson()
    {
        Assert.Equal("Hello, Amy, Brian, and Charlotte.", _sut.GreetMain("Amy", "Brian", "Charlotte"));
    }

    [Fact]
    public void ShouldGreetMorePersonAndGreetSomeoneShouted()
    {
        Assert.Equal("Hello, Amy and Charlotte. AND HELLO BRIAN!", _sut.GreetMain("Amy", "BRIAN", "Charlotte"));
    }

    [Fact]
    public void ShouldGreetMorePersonConcatenatedByComma()
    {
        Assert.Equal("Hello, Bob, Charlie, and Dianne.", _sut.GreetMain("Bob", "Charlie, Dianne"));
    }

    [Fact]
    public void ShouldGreetPersonWithInputDOubleQuotes()
    {
        Assert.Equal("Hello, Bob and Charlie, Dianne.", _sut.GreetMain("Bob", "\"Charlie, Dianne\""));
    }
}
