using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TextAnalyser.Domain.Interfaces;

namespace TextAnalyser.Application.Queries
{
	public class GetCharCount : GetCount
	{
		private readonly IAnalyser _analyser;

		public GetCharCount(IParser parser, IAnalyser analyser) : base(parser)
		{
			_analyser = analyser;
		}

		public int override Calculate()
		{
			//_analyser.CalculateCharacters(text)
		}
	}
}
