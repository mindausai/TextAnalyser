using FluentAssertions;
using NUnit.Framework;
using TextAnalyser.Domain.Services;

namespace TextAnalyser.Application.Tests
{
	public class AnalysisServiceTests
	{
		private readonly AnalysisService _analysisService;

		public AnalysisServiceTests()
		{
			_analysisService = new AnalysisService(new Parser(), new Analyser());
		}

		[Test]
		public void GetWordCount_GivenFileWith1Word_Calculates1Word()
		{
			var filePath = TestContext.CurrentContext.TestDirectory + @"\Data\test.txt";

			var result = _analysisService.GetWordCount(new string[1] { filePath });

			result.Should().Be("Word count is: 1");
		}

		[Test]
		public void GetWordCount_GivenIncorrectPath_FileNotFound()
		{
			var filePath = TestContext.CurrentContext.TestDirectory + @"\Data\t.txt";

			var result = _analysisService.GetWordCount(new string[1] { filePath });

			result.Should().Be("File not found");
		}
	}
}