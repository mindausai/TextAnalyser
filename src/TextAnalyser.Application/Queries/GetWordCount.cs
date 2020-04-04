using System;
using System.Collections.Generic;
using System.Text;
using TextAnalyser.Domain.Interfaces;

namespace TextAnalyser.Application.Queries
{
	public class GetWordCount
	{
		private readonly IParser _parser;
		private readonly IAnalyser _analyser;

		public GetWordCount(IParser parser, IAnalyser analyser)
		{
			_parser = parser;
			_analyser = analyser;
		}

		public string Do(string filePath)
		{
			var validationResult = _parser.ValidatePath(filePath);
			if (validationResult.Success)
			{
				var text = _parser.GetText(filePath);
				return _analyser.CalculateWords(text).ToString();
			}

			return validationResult.Message;
		}
	}
}
