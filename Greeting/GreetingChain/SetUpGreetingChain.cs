using System;
namespace Greeting.GreetingChain
{
	public class SetUpGreetingChain
	{
		private readonly ApproveStringParameters _chainApproveStringParameters;
		public SetUpGreetingChain()
		{
			var noParameter = new NoParameter();
			var oneParameter = new OneParameter();
			var moreParameter = new MoreParameter();

			noParameter.SetChainSuccessor(oneParameter);
			oneParameter.SetChainSuccessor(moreParameter);

			_chainApproveStringParameters = noParameter;
		}

		public ApproveStringParameters GetChain() => _chainApproveStringParameters;
	}
}

