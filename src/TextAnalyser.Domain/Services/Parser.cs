using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TextAnalyser.Domain.Models;

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
			if (File.Exists(filePath) || Path.GetExtension(filePath) == ".txt" )
			{
				return new ValidationResult()
				{
					Success = false,
					Message = "Path is incorrect"
				};
			}
			else
			{
				return new ValidationResult()
				{
					Success = true,
					Message = "Success"
				};
			}
		}
	}
}
