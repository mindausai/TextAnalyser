using System;
using System.Collections.Generic;
using System.Text;
using TextAnalyser.Domain.Interfaces;

namespace TextAnalyser.Domain.Services
{
	public class Analyser : IAnalyser
	{
		public int CalculateCharacters(string text)
		{
			return text.Length;
		}

		public int CalculateWords(string text)
		{
			char[] delimiters = new char[] { ' ', '\r', '\n' };
			return text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
		}
	}
}
