using FluentAssertions;
using NUnit.Framework;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;
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
			var fileUrl = TestContext.CurrentContext.TestDirectory + @"\Data\test.txt";

			var validationResult = _parser.ValidatePath(fileUrl);

			validationResult.Success.Should().BeTrue();
			
		}

		[Test]
		public void ValidateFilePath_GivenValidFolderPath_ValidateIsNotSuccessfull()
		{
			var fileUrl = TestContext.CurrentContext.TestDirectory + @"\Data";

			var validationResult = _parser.ValidatePath(fileUrl);

			validationResult.Success.Should().BeFalse();
			validationResult.Message.Should().Be("File not found");
		}


		[Test]
		public void ValidateFilePath_GivenFileWithDifferentExtension_ValidateIsNotSuccessfull()
		{
			var fileUrl = TestContext.CurrentContext.TestDirectory + @"\Data\test.data";

			var validationResult = _parser.ValidatePath(fileUrl);

			validationResult.Success.Should().BeFalse();
			validationResult.Message.Should().Be("Incorrect file extension");
		}

		[Test]
		public async Task GetText_GivenTestData_ReturnsFileText()
		{
			var fileUrl = TestContext.CurrentContext.TestDirectory + @"\Data\test.txt";

			var text = await _parser.GetText(fileUrl);

			text.Should().Be("test");
		}

		
	}
}