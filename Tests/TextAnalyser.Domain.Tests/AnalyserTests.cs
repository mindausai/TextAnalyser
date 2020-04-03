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
		public void CalculateWords_GivenTextWith1Word_Get1Word()
		{
			var text = "Hello";

			var wordCount = _analyser.CalculateWords(text);

			wordCount.Should().Be(1);
		}

		[Test]
		public void CalculateWords_GivenTextWith7Words_CalculatesCorrectly()
		{
			var text = "Hello" +
				" Everyone. This is a new sentence! ";

			var wordCount = _analyser.CalculateWords(text);

			wordCount.Should().Be(7);
		}

		[Test]
		public void CalculateCharacters_GivenTextWith1Word_Gets5Chars()
		{
			var text = "Hello";

			var wordCount = _analyser.CalculateCharacters(text);

			wordCount.Should().Be(5);
		}
	}
}
