using NUnit.Framework;
using System.ComponentModel.DataAnnotations;
using System.IO;
using TextAnalyser.Domain.Services;

namespace TextAnalyser.Domain.Tests
{
	public class ParserTests
	{
		private Parser _parser;

		public ParserTests()
		{
			_parser = new Parser();
		}

		[Test]
		public void ValidateFilePath_GivenValidFilePath_DetectThatFileExists()
		{
			var fileUrl = File.ReadAllText(TestContext.CurrentContext.TestDirectory + "\\Data\\test.txt");

			var validationResult = 
		}
	}
}