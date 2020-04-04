using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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

		public async Task<string> GetWordCount(string[] args)
		{
			return await new GetWordCount(_parser, _analyser).Do(args[0]);
		}

		public async Task<string> GetCharacterCount(string[] args)
		{
			return await new GetCharCount(_parser, _analyser).Do(args[0]);
		}
	}
}
