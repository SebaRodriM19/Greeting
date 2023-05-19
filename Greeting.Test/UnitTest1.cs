using Greeting.GreetingChain;

namespace Greeting.Test;

public class GreetingTest
{
    //object Greeting
    private readonly IGreeting _sut;
    //chain of responsabilities
    private readonly ApproveStringParameters _sutOne;

    public GreetingTest()
    {
        _sut = new Greeting();
        _sutOne = new SetUpGreetingChain().GetChain();
    }

    //Test with object Greeting
    [Fact]
    public void SimpleGreet() => Assert.True(true);

    [Fact]
    public void ShouldReturnGreetPerson() => Assert.Equal("Hello, Bob.", _sut.GreetMain("Bob"));

    [Fact]
    public void ShouldReturnGreetNullPerson() => Assert.Equal("Hello, my friend.", _sut.GreetMain(null));

    [Fact]
    public void ShouldReturnGreetShouted() => Assert.Equal("HELLO BOB!", _sut.GreetMain("BOB"));

    [Fact]
    public void ShouldGreetTwoPerson() => Assert.Equal("Hello, Jill and Jane.", _sut.GreetMain("Jill", "Jane"));

    [Fact]
    public void ShouldGreetMorePerson() => Assert.Equal("Hello, Amy, Brian, and Charlotte.", _sut.GreetMain("Amy", "Brian", "Charlotte"));

    [Fact]
    public void ShouldGreetMorePersonAndGreetSomeoneShouted() => Assert.Equal("Hello, Amy and Charlotte. AND HELLO BRIAN!", _sut.GreetMain("Amy", "BRIAN", "Charlotte"));

    [Fact]
    public void ShouldGreetMorePersonConcatenatedByComma() => Assert.Equal("Hello, Bob, Charlie, and Dianne.", _sut.GreetMain("Bob", "Charlie, Dianne"));

    [Fact]
    public void ShouldGreetPersonWithInputDOubleQuotes() => Assert.Equal("Hello, Bob and Charlie, Dianne.", _sut.GreetMain("Bob", "\"Charlie, Dianne\""));
    
    //Test with chain
    [Fact]
    public void ShouldReturnGreetPersonChain() => Assert.Equal("Hello, Bob.", _sutOne.Greet("Bob"));

    [Fact]
    public void ShouldReturnGreetNullPersonChain() => Assert.Equal("Hello, my friend.", _sutOne.Greet(null));

    [Fact]
    public void ShouldReturnGreetShoutedChain() => Assert.Equal("HELLO BOB!", _sutOne.Greet("BOB"));

    [Fact]
    public void ShouldGreetTwoPersonChain() => Assert.Equal("Hello, Jill and Jane.", _sutOne.Greet("Jill", "Jane"));

    [Fact]
    public void ShouldGreetMorePersonChain() => Assert.Equal("Hello, Amy, Brian, and Charlotte.", _sutOne.Greet("Amy", "Brian", "Charlotte"));

    [Fact]
    public void ShouldGreetMorePersonAndGreetSomeoneShoutedChain() => Assert.Equal("Hello, Amy and Charlotte. AND HELLO BRIAN!", _sutOne.Greet("Amy", "BRIAN", "Charlotte"));

    [Fact]
    public void ShouldGreetMorePersonConcatenatedByCommaChain() => Assert.Equal("Hello, Bob, Charlie, and Dianne.", _sutOne.Greet("Bob", "Charlie, Dianne"));

    [Fact]
    public void ShouldGreetPersonWithInputDOubleQuotesChain() => Assert.Equal("Hello, Bob and Charlie, Dianne.", _sutOne.Greet("Bob", "\"Charlie, Dianne\""));

}
