using System;

namespace Treehouse.FitnessFrog
{	
	class Program 
	{
		static void Main()
		{
			int total = 0;

			Console.Write("Enter how many minutes you excercised: ");

			string input = Console.ReadLine();
			total += int.Parse(input);

			Console.WriteLine(total);
		}
	}
}