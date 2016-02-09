using System;

namespace Umholtz_Tomas_Functions_Assignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			/*
			Name: Tommy Umholtz
			Assignment: Functions
			Date: 12/12/15
			Class: SDI
			Section: 01
			*/

			/*
			This is a calculator to determine how many hours your transit time might be taking a flight
			with and with out layover time
			*/

			Console.WriteLine ("Please enter your name and press return.");

			//Space for the user to enter there name and for it to be stored as a string
			string username = Console.ReadLine ();

			while (string.IsNullOrWhiteSpace (username)) {

				//inform user
				Console.WriteLine ("Please do not leave blank. \r\n Please type in your name.");

				//redefine the variable
				username = Console.ReadLine ();

			}

			//tell user what the program is for
			Console.WriteLine ("Hello {0}! This is a flight time calculator.",username);

			//asking for the number of miles the users flight will be
			Console.WriteLine ("How many miles will you fly during your trip total?");

			//space for the user to enter the total miles they will fly
			string milesString = Console.ReadLine ();

			//declare variable to hold converted value
			float milesInt;

			//validate user is typing a number using a while loop, if so store as an integer in the 
			//variable milesInt
			while (!float.TryParse (milesString, out milesInt)) {

				//tell the user
				Console.WriteLine ("Please type the amount of miles you will fly.");

				//redefine the variable
				milesString = Console.ReadLine ();

			}

			//asking for the average speed of their plane(s) in miles per hour
			Console.WriteLine ("What is the average speed of your plane(s) in miles per hour?");

			//Space for the user to enter the average speed of their plane in miles per hour
			string speedString = Console.ReadLine ();

			//declare variable to hold converted value
			float speedInt;

			//validate user is typing a number using a while loop, if so store as an integer in the 
			//variable speedInt
			while (!float.TryParse (speedString, out speedInt)) {

				//tell the user
				Console.WriteLine ("Please type the average speed of your plane.");

				//redefine the variable
				speedString = Console.ReadLine ();

			}

			//tell user
			Console.WriteLine ("Your miles are {0} and your planes average speed is {1}",milesInt,speedInt);

			//function call to using function code to calculate travel time with out a layover
			float noLayover = calcNolayover (milesInt, speedInt);

			//tell user
			Console.WriteLine ("With out any layovers your transit time will be {0} hours.",noLayover);


			//asking for hours they will spend on layover
			Console.WriteLine ("How many hours will you spend on layover?");

			//Space for the user to enter the amount of layover time they'll have
			string layoverString = Console.ReadLine ();

			//declare variable to hold converted value
			float layoverInt;

			//validate user is typing a number using a while loop, if so store as an integer in the 
			//variable layoverInt
			while (!float.TryParse (layoverString, out layoverInt)) {

				//tell the user
				Console.WriteLine ("Please type the amount of hours you will spend on layover.");

				//redefine the variable
				layoverString = Console.ReadLine ();
			}
			//function call to using function code to calculate travel time with a layover
			float wLayover = withLayover (milesInt, speedInt, layoverInt);

			//tell user
			Console.WriteLine ("Layover time has been factored into your transit time which will be {0} hours.",wLayover);

		}

		public static float calcNolayover(float m, float s){

			//create a variable for flight time and calculate
			float noLayover = m/s;

			//return without layover value
			return noLayover;

		}


		public static float withLayover(float m, float s, float l){

			//create a variable for total transite time including layover and calculate
			float wLayover = (m/s)+l;

			//return with layover value
			return wLayover;


			/* 
			Calculations:
			9000 (flight miles) / 500 (miles per hour) = 18 (hours) + 7 (layover hours) = 25 (total transit hours)
			*/

		}

	}

}


