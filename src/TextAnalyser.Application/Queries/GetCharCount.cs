using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TextAnalyser.Domain.Interfaces;

namespace TextAnalyser.Application.Queries
{
	public class GetCharCount
	{
		private readonly IParser _parser;
		private readonly IAnalyser _analyser;

		public GetCharCount(IParser parser, IAnalyser analyser)
		{
			_parser = parser;
			_analyser = analyser;
		}

		public async Task<string> Do(string filePath)
		{
			var validationResult = _parser.ValidatePath(filePath);
			if (validationResult.Success)
			{
				var text = await _parser.GetText(filePath);
				return $"Character count is: { _analyser.CalculateCharacters(text) }";
			}

			return validationResult.Message;
		}
	}
}
