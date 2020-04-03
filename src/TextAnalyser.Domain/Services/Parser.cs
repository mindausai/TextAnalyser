using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TextAnalyser.Domain.Models;
using TextAnalyser.Domain.Validations;

namespace TextAnalyser.Domain.Services
{
	public class Parser
	{
		
		public Parser()
		{
			
		}
		public string GetText(string fileUrl)
		{
			throw new NotImplementedException();
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
