using Greeting.IOC;
using Microsoft.Extensions.DependencyInjection;

var host = StartUp.CreateHostBuilder().Build();
var greeting = host.Services.GetService<Greeting.Greeting>();

Console.WriteLine(greeting.GreetMain("Sebastian"));