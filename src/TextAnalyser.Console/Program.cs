using System;
using Microsoft.Extensions.DependencyInjection;
using TextAnalyser.Application;
using TextAnalyser.Domain.Interfaces;
using TextAnalyser.Domain.Services;

namespace TextAnalyser.ConsoleApp
{
	public class Program
	{
		private static IServiceProvider _serviceProvider;


		static void Main(string[] args)
		{
			RegisterServices();

			var analysisService = _serviceProvider.GetService<AnalysisService>();

			Console.WriteLine(analysisService.GetWordCount(args));

			Console.WriteLine(analysisService.GetCharacterCount(args));
		}

		private static void RegisterServices()
		{
			var collection = new ServiceCollection();
			collection.AddScoped<IParser, Parser>();
			collection.AddScoped<IAnalyser, Analyser>();
			collection.AddScoped<AnalysisService>();

			_serviceProvider = collection.BuildServiceProvider();
		}
	}
}
