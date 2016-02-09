using System;

namespace Week_Four_Notes_3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			/*
			Name: Tommy Umholtz
			Assignment: **
			Date: 12/09/15
			Section: 01
			*/

			//calculate the area and perimeter of a rectangle from user prompts

			//Being polite, asking the users name
			Console.WriteLine ("Please type your name and press enter.");

			//Space for the user to enter there name and for it to be stored as a string
			string userName = Console.ReadLine();

			//Say hello to the user and introduce the purpose of the calculator
			Console.WriteLine ("Hello " + userName + " welcome the rectangle parimeter and area calculator!");

			//asking for the with
			Console.WriteLine ("Please type a value for the width.");

			//Space for the user to enter there width and for it to be stored as a string
			string widthString = Console.ReadLine();

			//declare variable to hold converted value
			double width;

			//validate user is typing a number using a while loop.

			while ( ! double.TryParse (widthString, out width)) {

				//tell user
				Console.WriteLine ("You have entered something other than a number.\r\n Please type a value for the width.");

				//collect user responce, do not redeclare data type
				widthString = Console.ReadLine ();

			}


			//tell user
			Console.WriteLine ("The width is {0}.\r\n", width);


			//asking for the lenght
			Console.WriteLine ("Please type a value for the lenght.");

			//Space for the user to enter there width and for it to be stored as a string
			string lenghtString = Console.ReadLine();

			//declare variable to hold converted value
			double lenght;

			//validate user is typing a number using a while loop.

			while ( ! double.TryParse (lenghtString, out lenght)) {

				//tell user
				Console.WriteLine ("You have entered something other than a number.\r\n Please type a value for the lenght.");

				//collect user responce, do not redeclare data type
				lenghtString = Console.ReadLine ();

			}

			//tell user
			Console.WriteLine ("The lenght is {0}.\r\n", lenght);

			Console.WriteLine ("With your lenght of {0} and width of {1} we will calculate the perimeter and area.\r\n",lenght, width);

			//function call to catch the returned value with a variable and use arguments
			double perimeter = calcPeri (width,lenght);

			//tell user
			Console.WriteLine ("The perimeter of the rectangle is "+perimeter);

			//function call to catch the returned value with a variable and use arguments
			double area = calcArea (width,lenght);

			//tell user
			Console.WriteLine ("The area of the rectangle is {0}.",area);

			//Tell the user we want to find the volume, ask for height.
			Console.WriteLine ("Finding the volume a rectangular prism.\r\nWhat is the Height?");

			//capture height value from user input
			string heightString = Console.ReadLine();

			//convert string variable to double
			double height;

			while ( ! double.TryParse (heightString, out height)) {

				//tell user
				Console.WriteLine ("You have entered something other than a number.\r\nPlease type a value for the height.");

				//collect user responce, do not redeclare data type
				heightString = Console.ReadLine ();

			}

			//tell user
			Console.WriteLine ("The height of the rectanglular prisim is " +height); 

			//function call to catch the returned value with a variable and use arguments
			double volume = calcVolume (width,lenght,height);

			//tell user volume of the rectangular prisim
			Console.WriteLine ("The volume of the rectanglular prisim is {0}.",volume);

			/*
			*calculations
			*/

		}

		//Function calculating the perimeter
		public static double calcPeri(double wid, double len){

			//create a variable for perimeter and calculate
			double peri = 2*wid + 2*len;

			//return perimeter value
			return peri;

		}

		//Function calculating the area (what happens in a method stays there)
		public static double calcArea(double wid, double len){

			//create a variable for area and calculate
			double area = wid*len;

			//return perimeter value
			return area;

		}

			//Function calculating the volum (what happens in a method stays there)
		 	public static double calcVolume(double w, double l, double h){

			//calculate volum
			double volume = w*l*h;

			//Return volum
			return volume;
		}



	}
}
