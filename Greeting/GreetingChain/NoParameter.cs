using System;
namespace Greeting.GreetingChain
{
	public class NoParameter : ApproveStringParameters
	{
		public NoParameter()
		{
		}

        public override string Greet(params string[] names)
        {
            if (names == null)
            {
                return "Hello, my friend.";

            } else if(_approveStringParametersSuccessor != null)
            {
                return _approveStringParametersSuccessor.Greet(names);
            }

            return string.Empty;
        }
    }
}

