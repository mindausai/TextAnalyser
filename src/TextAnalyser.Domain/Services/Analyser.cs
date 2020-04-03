using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyser.Domain.Services
{
	public class Analyser
	{
		public int CalculateCharacters(string text)
		{
			throw new NotImplementedException();
		}

		public int CalculateWords(string text)
		{
			char[] delimiters = new char[] { ' ', '\r', '\n' };
			return text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
		}
	}
}
