using Greeting.GreetingChain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Greeting.IOC
{
	public static class StartUp
	{
		public static IHostBuilder CreateHostBuilder()
		{
			return Host.CreateDefaultBuilder().ConfigureServices((contex,service) => {
				service.AddSingleton<IGreeting, Greeting>();
				service.AddSingleton<SetUpGreetingChain>();
			});
		}
	}
}

