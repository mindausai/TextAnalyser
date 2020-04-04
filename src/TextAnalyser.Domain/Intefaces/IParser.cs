using System.Threading.Tasks;
using TextAnalyser.Domain.Models;

namespace TextAnalyser.Domain.Interfaces
{
	public interface IParser
	{
		Task<string> GetText(string fileUrl);
		ValidationResult ValidatePath(string filePath);
	}
}