using System;
using System.Collections.Generic;
using System.Text;
using TextAnalyser.Domain.Models;

namespace TextAnalyser.Domain.Validations
{
	public interface IPathValidation
	{
		ValidationResult Validate(string path);
	}
}
