using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextAnalyser.Domain.Services
{
	public class Parser
	{
		private readonly Validator _validator;
		public Parser(Validator validator)
		{
			_validator = validator;
		}
		public string GetText(string fileUrl)
		{
			throw new NotImplementedException();
		}
	}
}
