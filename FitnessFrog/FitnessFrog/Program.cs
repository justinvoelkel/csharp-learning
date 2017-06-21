using System;

namespace Treehouse.FitnessFrog
{	
	class Program 
	{
		static void Main()
		{
			int total = 0;
			bool cont = true;

			while(cont)
			{
				Console.Write("Enter how many minutes you excercised or q to quit: ");
				string input = Console.ReadLine();

				if(input == "q"){
					cont = false;
					break;
				} else {
					try{
						total += int.Parse(input);
						string response = Program.responseLogic(total);
						Console.WriteLine(response);
						continue;
					} catch(FormatException) {
						Console.WriteLine("Sorry, that is not a valid input");
						break;
					}
				}//end else
			}//end while
		}//end Main

		public static string responseLogic(int hours)
		{
			string response = "Sorry, that input is invalid";

			if(hours < 0) {
				return response;
			} else if(hours <= 10){
				response = "Better than nothing I guess...";
			} else if(hours > 10 && hours <= 30) {
				response = "Not bad, getting better...";
			} else if(hours > 30 && hours <= 60) {
				response = "Damn, Daniel...";
			} else if (hours > 60) {
				response = "Showoff...";
			}

			return response;

		}//end logic method

	}//end Program
}