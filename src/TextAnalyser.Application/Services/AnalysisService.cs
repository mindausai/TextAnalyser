using System;
using System.Collections.Generic;
using System.Text;
using TextAnalyser.Application.Queries;
using TextAnalyser.Domain.Interfaces;
using TextAnalyser.Domain.Services;

namespace TextAnalyser.Application
{
	public class AnalysisService
	{
		private readonly IParser _parser;
		private readonly IAnalyser _analyser;

		public AnalysisService(IParser parser, IAnalyser analyser)
		{
			_parser = parser;
			_analyser = analyser;
		}

		public string GetWordCount(string[] args)
		{
			return new GetWordCount(_parser, _analyser).Do(args[0]);
		}

		public string GetCharacterCount(string[] args)
		{
			throw new NotImplementedException();
		}
	}
}
