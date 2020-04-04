using TextAnalyser.Domain.Models;

namespace TextAnalyser.Domain.Interfaces
{
	public interface IParser
	{
		string GetText(string fileUrl);
		ValidationResult ValidatePath(string filePath);
	}
}