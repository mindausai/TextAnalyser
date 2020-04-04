namespace TextAnalyser.Domain.Interfaces
{
	public interface IAnalyser
	{
		int CalculateCharacters(string text);
		int CalculateWords(string text);
	}
}