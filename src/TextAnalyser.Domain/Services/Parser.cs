using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyser.Domain.Interfaces;
using TextAnalyser.Domain.Models;
using TextAnalyser.Domain.Validations;

namespace TextAnalyser.Domain.Services
{
	public class Parser : IParser
	{

		public Parser()
		{

		}
		public async Task<string> GetText(string fileUrl)
		{
			using (var reader = File.OpenText(fileUrl))
			{
				return await reader.ReadToEndAsync();

			}
		}

		public ValidationResult ValidatePath(string filePath)
		{
			var validationChecks = new List<IPathValidation>()
			{
				new ExistingPathValidation(),
				new FileExtensionValidation()
			};

			var validationResults = validationChecks.Select(v => v.Validate(filePath));


			if (validationResults.Any(v => !v.Success))
			{
				return validationResults.FirstOrDefault(v => !v.Success);
			}
			else
			{
				return new ValidationResult() { Success = true };
			}

		}
	}
}
