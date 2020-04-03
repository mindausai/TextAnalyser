using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TextAnalyser.Domain.Models;

namespace TextAnalyser.Domain.Validations
{
	public class ExistingPathValidation : IPathValidation
	{
		public ValidationResult Validate(string path)
		{
			return File.Exists(path) ?
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
