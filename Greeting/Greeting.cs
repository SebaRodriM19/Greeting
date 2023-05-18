using System;
namespace Greeting
{
	public class Greeting
	{
		public Greeting()
		{
		}

		public string Greet(string name)
		{
			if (name != null)
			{
               return $"Hello, {name}";
            }
			else
			{
				return "Hello, my friend";
			}
		}

		public string ShoutedGreet(string name)
		{
			for (int i = 0; i < name.Length; i++)
			{
				if (!char.IsUpper(name[i]))
				{
					return "Name not shouted";
				}
			}

			return $"HELLO {name}!";
		}

        public string GreetTwoPerson(params string[] names)
		{
			var greet = $"Hello, {names[0]} and {names[1]}";

			return greet;
		}

        public string GreetMorePerson(params string[] names)
        {
			var greet = "Hello, ";

			for (int i = 0; i < names.Length; i++)
			{
				if (i < (names.Length-1))
				{
					greet = greet + $"{names[i]}, ";
				}
				else
				{
					greet = greet + $"and {names[i]}.";
				}
			}

			return greet;
        }
    }
}

