using System;
using System.Text.RegularExpressions;

namespace Csharpregex
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string teststring = "1.200.200.3";
			string resultstring;
			resultstring = Regex.Replace (teststring, @"\.\*", "");
		}
	}
}
