using System;
namespace Greeting.GreetingChain
{
	public class OneParameter : ApproveStringParameters
	{
		public OneParameter()
		{
		}

        public override string Greet(params string[] names)
        {
            if (names.Length == 1)
            {
                return names[0] == names[0].ToUpper() ? $"HELLO {names[0].ToUpper()}!" : $"Hello, {names.First()}.";
            }
            else if (_approveStringParametersSuccessor != null)
            {
                return _approveStringParametersSuccessor.Greet(names);
            }

            return string.Empty;
        }
    }
}

