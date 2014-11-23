using System;

namespace PrimePalindrome
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Print out the largest prime palindrome less than 'n'
			var n = 1000;

			bool found = false;

			while (!found) 
			{
				if (IsPrime (n) && IsPalindrome (n)) 
				{
					found = true;
					Console.WriteLine (n);
				}
					
				n--;
			}
		}

		public static bool IsPrime (int n)
		{
			for (int i = 2; i < Math.Sqrt (n); i++) 
			{
				var absVal = (double)n / (double)i;
				var floorVal = Math.Floor ((double)(n / i));
				if (absVal == floorVal) 
				{
					return false;
				}
			}
			return true;
		}

		public static bool IsPalindrome (int n)
		{
			var nStr = n.ToString();
			var nLength = nStr.Length;

			for (int i = 0; i < Math.Ceiling((double)nLength/2); i++) 
			{
				if (nStr[i] != nStr[nLength - i - 1])
				{
					return false;
				}
			}

			return true;
		}
	}


}
