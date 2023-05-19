using System;
namespace Greeting.GreetingChain
{
	public abstract class ApproveStringParameters
	{
		protected ApproveStringParameters? _approveStringParametersSuccessor;

		public ApproveStringParameters()
		{
		}

		public void SetChainSuccessor(ApproveStringParameters approveStringParameters)
		{
			_approveStringParametersSuccessor = approveStringParameters;
		}

		public abstract string Greet(params string[] names);
	}
}

