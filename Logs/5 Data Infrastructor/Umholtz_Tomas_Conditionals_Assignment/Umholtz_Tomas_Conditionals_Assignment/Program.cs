using System;

namespace Umholtz_Tomas_Conditionals_Assignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			/*
			Name: Tommy Umholtz
			Assignment: Conditionals
			Date: 12/07/15
			Section: SDI 01
			*/

			/*
			Project Requirements:
			a mathematical calculation using at least 2 non hard-coded variables
			2 conditional statements not part of a prompt, one must contain an else if statement
			1 else if statement
			1 logical operator && || !
			3 user prompts
			all prompts checked and validated
			code is commented on
			a verified final calculation is given
			*/

				/*
				this is a calculator to determine wether to go out to a 
				restaurant or eat something at home
				*/

				/*
				Calculator requirements:
				*/

			//user Prompt asking users name
			Console.WriteLine ("Please type your name and press enter.");

			//Space for the user to enter there name and for it to be stored as a string
			string userName = Console.ReadLine();

			if (string.IsNullOrWhiteSpace (userName)) {
				//if the user entered the wrong info they will be prompted to reenter it correctly
				Console.WriteLine ("Please don't leave blank, enter your name.");
				userName = Console.ReadLine ();
			}

			//Say hello to the user and introduce the purpose of the calculator
			Console.WriteLine ("Hello " + userName + " this calculator will help you determine where you should go for\r\ndinner this evening.");

			//prompt asking user how much money they have spent this week
			Console.WriteLine ("How much money have you spent in the last week\r\nenter a dollar amount with out the dollar sign?");
			//Space for the user to enter the amount of money they've spent this week and for it to be stored as a string
			string moneySpentString = Console.ReadLine ();

			//declaring variable as a decimal
			decimal moneySpentDecimal;
			//attempting to parse string to decimal
			if (!(decimal.TryParse (moneySpentString, out moneySpentDecimal))) {


				//if the user entered the wrong info they will be prompted to reenter it correctly
				Console.WriteLine ("You entered something other than a whole dollar amount without the dollar sign, try again.");
				//Space for the user to enter the amount of money they've spent this week and for it to be stored as a string
				moneySpentString = Console.ReadLine ();
				decimal.TryParse (moneySpentString, out moneySpentDecimal);

			}

			//prompt asking user what their budget is for the week
			Console.WriteLine ("What is your budget for the week\r\nenter a dollar amount with out the dollar sign?");
			//Space for the user to enter their budget this week and for it to be stored as a string
			string BudgetString = Console.ReadLine ();

			//declaring variable as a decimal
			decimal budgetDecimal;
			//attempting to parse string to decimal
			if (!(decimal.TryParse (BudgetString, out budgetDecimal))) {


				//if the user entered the wrong info they will be prompted to reenter it correctly
				Console.WriteLine ("You entered something other than a whole dollar amount without the dollar sign, try again.");
				//Space for the user to enter their budget this week and for it to be stored as a string
				BudgetString = Console.ReadLine ();
				decimal.TryParse (BudgetString, out budgetDecimal);
			}

			//mathmatical calculations finding the difference between the budgetDecimal and the moneySpentDecimal 
			decimal budgetSpentDecimal = (budgetDecimal - moneySpentDecimal);
			//one of two required non prompt conditional statements
			//one of one required else if conditional statement
			if (budgetSpentDecimal >= 50) {
				//recomends user to wether they should go out for a meal, informs them there is another prompt
				Console.WriteLine ("You are $"+budgetSpentDecimal+" under budget,\r\nyou could go out for a nice meal, proceed to the next step.");

			}  else if (budgetSpentDecimal < 50 && budgetSpentDecimal > 0) {
				//recomends user to wether they should go out for a meal, informs them there is another prompt
				Console.WriteLine ("You are only $"+budgetSpentDecimal+" under budget not so good,\r\nyou have enough for a couple of tacos and soda, proceed to the next step.");

			}  else {
				//recomends user to wether they should go out for a meal, informs them there is another prompt
				Console.WriteLine ("You are currently over budget find something to eat at home, save your money,\r\nbut proceed to the next step anyways.");

			}

			//prompt asking user how many times they have eaten at a restaurant this week
			Console.WriteLine ("How many times have you eaten at a restaurant for dinner with in the last week?");
			//Space for the user to enter how many times they've eaten at a restaurant this week
			string restaurantString = Console.ReadLine ();

			//declaring variable as a decimal
			decimal restaurantDecimal;
			//attempting to parse string to decimal
			if (!(decimal.TryParse (restaurantString, out restaurantDecimal))) {


				//if the user entered the wrong info they will be prompted to reenter it correctly
				Console.WriteLine ("You entered something other than a whole number, try again.");
				//Space for the user to enter how many times they've eaten at a restaurant this week
				restaurantString = Console.ReadLine ();
				decimal.TryParse (restaurantString, out restaurantDecimal);
			}

			//two of two required non prompt conditional statements
			//two of one required else if conditional statement
			if (budgetSpentDecimal >= 50 && restaurantDecimal < 3) {

				//recomends user to wether they should go out for a meal
				Console.WriteLine ("You are $"+budgetSpentDecimal+" under budget and haven't been out to many times,\r\ngo to a restaurant, take a date and buy some Champaign.");

			}  else if ((budgetSpentDecimal < 50 && budgetSpentDecimal > 0) && restaurantDecimal < 3) {
						//recomends user to wether they should go out for a meal
						Console.WriteLine ("You have $"+budgetSpentDecimal+" and haven't been out to many times,\r\ngo get those tacos.");

					}  else if (budgetSpentDecimal > 0 && restaurantDecimal > 3) {
						//recomends user to wether they should go out for a meal
						Console.WriteLine ("Your budget is good but since you've already been out a few \r\ntimes this week so might as well stay in and cook.");

					}  else {
						//recomends user to wether they should go out for a meal
						Console.WriteLine ("Since you probably didn't get paid between now\r\nand the first step you should still find something to eat at home.");

					}
					
			//Test Value Example: 1200 (budgetDecimal) - 1150 (spentDecimal) = 50 (budgetSpentDecimal)
					
			}
		}
	}