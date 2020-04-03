using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyser.Domain.Models
{
	public class ValidationResult
	{
		public bool Success { get; set; }
		public string Message { get; set; }
	}
}
