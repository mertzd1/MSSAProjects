using System;
using System.Collections.Generic;
using System.Linq;

namespace GreatestCharInAString
{
	class Program
	{
		static void Main(string[] args)
		{
			string input="Schools" ;
			int count;
			Console.WriteLine(HighFreq( input));
		}



		static char HighFreq(string input)
		{
			Dictionary<string, int> MostFreq = new Dictionary<string, int>();

			foreach (char c in input)
			{

				foreach (KeyValuePair<string, int> item in MostFreq)
				{
					if (c == item.Key)
					{
						item.Value++
					}
					else
					{
						MostFreq.Add(new KeyValuePair<string, int>(c, 1));
					}
				}
			}
			var maxValue = MostFreq.Value.Max
			foreach (KeyValuePair in MostFreq)
			{
				if (maxValue == item.Value)
				{
					return item.Key;
				}
			}
		}
	}
}
