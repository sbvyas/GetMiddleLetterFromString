using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMiddleLetterFromAString
{
	class Program
	{
		static void Main(string[] args)
		{
			string aGetLetter = Console.ReadLine();
			Console.WriteLine("Middle Letter : " + GetMiddleLetters(aGetLetter));
			Console.ReadLine();
		}
		private static string GetMiddleLetters(string input)
		{
			//Find the middle point
			var mid = input.Length / 2.0;

			//If it's odd, we take 1 letter, if it's even, we take 2
			var numToTake = (mid == (int)mid) ? 2 : 1;

			//Round up from the middle, and subtract one (as Substring is 0-indexed)
			var startIndex = (int)Math.Ceiling(mid) - 1;

			return input.Substring((int)Math.Ceiling(mid) - 1, numToTake);
			
		}
	}
}
