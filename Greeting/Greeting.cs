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
	}
}

