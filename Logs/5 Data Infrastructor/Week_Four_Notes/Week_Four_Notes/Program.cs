using System;

namespace Week_Four_Notes
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			/*
			Name: Tommy Umholtz
			Week 4 Notes
			Date: 12/08/15
			Section: SDI 01
			*/



			//**Loop** 15_01_AdvStringCate



			double myNum = 11.7157;
			Console.WriteLine ("The value is " + myNum);

			string test = String.Format ("The meaning of what is {0}.", 44);
			Console.WriteLine (test);

			double otherNum = 36;

			double thatNum = 23;

			Console.WriteLine ("The first number is {0} and the second number is {1} and that number is {2}.", myNum, otherNum, thatNum);



			//**Loops** 15_02_WhileLoops



			/*Code type review:
			 * Sequential
			 * Conditiona;
			 * Repetitive
			 * Reusable
			*/

			//While loop - intialize the variable, test condition, code block, incrament of change
			//inside the code block there needs to be an incrament of change, 
			//otherwise the loop will not end
			//open ended

			int i = 0;
			while (i <= 10) {
				Console.WriteLine (i);

				i++;

			}

			//declare and define starting counting variable

			int counter = 0;

			while (counter < 23) {

				Console.WriteLine ("The counter is {0}.", counter);

				//increment of change to the counter variable

				counter += 5;

			}



			//**Loops** 15_03_ValidationWhileLoop



			Console.WriteLine ("Please enter your name and press return.");

			//Space for the user to enter there name and for it to be stored as a string
			string username = Console.ReadLine ();

			while (string.IsNullOrWhiteSpace (username)) {

				//tell the user
				Console.WriteLine ("Please do not leave blank.\r\nPlease type in your name.");

				//redefine the varaiable
				username = Console.ReadLine ();

			}


			Console.WriteLine ("Hello {0}! Please enter a number.", username);
			string numberString = Console.ReadLine ();

			//Declare a variable to hold a converted value
			double userNum;

			while (!double.TryParse (numberString, out userNum)) {

				//tell user
				Console.WriteLine ("You have entered something other than a number.\r\n Enter a number");

				//collect user responce
				numberString = Console.ReadLine ();

			}

			Console.WriteLine ("The number you typed in is {0}.\r\n", userNum);

			//loops always run if the statement is true



			//**Loops** 15_04_DoWhileLoop



			//Declare and define a variable
			int ii = 45;

			//do while loops always runat least once, then check
			do {

				Console.WriteLine ("The value of ii is {0}", ii);

				//increment of change
				ii -= 5;

			} while(ii > 5);



			//**Loops** 15_05_ForLoops



			//for loops
			/*
			for( int iii = 0; iii < 10 ; iii++)
			{
			Console.WriteLine(iii);
			}
			*/

			//for(variable; test; increment of change)
			//code block

			for(int counter1 = 0; counter1<=11; counter1++){

				Console.WriteLine ("The value of counter1 is {0}.", counter1);

			}



			//**Loops** 15_06_ForEachLoop




			/*foreach(int i in arrayName){

				Console.WriteLine;

			}
			*/

			//create an arrary
			int[] myBills = new int[6]{23,36,44,57,71,11};

			//Create foreach loop
			foreach (int arrayitem in myBills){

				Console.WriteLine ("The item in the arrary is {0}", arrayitem);

			}

			//Create a variable to hold the sum
			int totalSum = 0;

			foreach (int eachBill in myBills){

				//add each bill to the total sum
				totalSum = totalSum + eachBill;

				//totalSum +=eachBill

			}

			Console.WriteLine ("The sum of out bills is {0}", totalSum);



			//**Loops** 15_07_BreaksContinue



			for(int counter2 = 0; counter2<=11; counter2++){

				Console.WriteLine ("The value of counter1 is {0}.", counter2);

				if(counter2==2){
					Console.WriteLine ("Stoping the loop");
					break;

				}

			}


			//the break ** will stop the loop
			//continue will skip an iteration

			for (int iiii = 0; iiii < 50; iiii++) {


				//add things you want to skip into this statement 
				if (iiii % 2 ==0) {
					continue;

					//Console.WriteLine ("Stoping the loop");
					//break;
				}

				Console.WriteLine ("The value of iiii is {0}.", iiii);

			}



			//**Loops** 15_08_ZombieMadness



			//fucking zombies
			//one zombie infects 4 people per day
			//how many total zombies in 8 days

			//initial zombie count
			int numZombies = 1;


			//each zombie bites bite amount
			int numBites = 4;

			//how many days
			int days = 23;

			//cycle loop
			for(int iiiii=1; iiiii <= days; iiiii++){
				//what happens each day
				//how many new zombies
				int newZombies = numZombies * numBites;

				//each day these new zombies join the horde

				// += add to total, change value
				numZombies += newZombies;

				//inform new zombie total
				Console.WriteLine("There are {0} zombies on day no. {1}", numZombies, iiiii);

			}
			 

			//How long will it take to reach 1 million zombies

			int numDays = 1;

			int zombieHordeNumber = 1;

			while(zombieHordeNumber<=1000000){

				//Happens each day
				int bittenPeople = zombieHordeNumber * numBites;

				//each day these new zombies join the horde

				// += add to total, change value
				zombieHordeNumber += bittenPeople;

				//inform new zombie total
				Console.WriteLine("There are {0} zombies on day no. {1}", zombieHordeNumber, numDays);

				numDays++;

			}



			//**Functions** 16_01_FunctionsOverview



			//reusable code type = function = method
			//variables store values, functions store blocks of code
			 


			//**Functions** 16_02_FunctionStructure



			//public - private - protected and internal
			//method modifier for public or private - static
			//return type - 



			//**Functions** 16_03_VariableScope



			//**Functions** 16_04_ReturnValue



			//**Functions** 16_05_ArgumentsParameter



			//**Functions** 16_06_BringingItAllTogether





		}
	}
}
 