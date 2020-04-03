using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TextAnalyser.Domain.Models;

namespace TextAnalyser.Domain.Validations
{
	public class FileExtensionValidation : IPathValidation
	{
		public ValidationResult Validate(string path)
		{
			return Path.GetExtension(path) == ".txt" ?
				new ValidationResult()
				{
					Success = true,
					Message = "Success"
				}
				:
				new ValidationResult()
				{
					Success = false,
					Message = "Path does not exist"
				};
		}
	}
}
