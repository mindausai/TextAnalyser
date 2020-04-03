using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TextAnalyser.Domain.Services;

namespace TextAnalyser.Domain.Tests
{
	
	public class AnalyserTests
	{
		private readonly Analyser _analyser;

		public AnalyserTests()
		{
			_analyser = new Analyser();
		}

		[Test]
		public void CalculateWords_GivenTextWithSingleWord_GetSingleWord()
		{
			var text = "Hello";

			var wordCount = _analyser.CalculateWords(text);

			wordCount.Should().Be(1);
		}
	}
}
