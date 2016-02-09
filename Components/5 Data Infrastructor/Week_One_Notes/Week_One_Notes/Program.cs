using System;

namespace Week_One_Notes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//**Values and Variables** 07_01 Variables Character Type



			//Variables - Characters

			//Characters - char - only one character in size
			//surrounded by single quotes

			//Declare a Variable

			char firstLetter;

			//Define the variable

			firstLetter = 'A' ;

			//print the variable to our console

			Console.WriteLine(firstLetter);

			//Declare and Define a variable

			char secondCharacter = 'b' ;

			//Print the variable to the console

			Console.WriteLine(secondCharacter);

			//String of characters - more than a single character
			//surrounded by double quotes

			string wholeSentence = "Here is a sentence.";

			//print out the variable

			Console.WriteLine(wholeSentence);

			//Combing String
			string combinedString = "First Part"+"Second Part";
			Console.WriteLine (combinedString);

			string firstName = "Kermit";
			string lastName = "The Frog";
			string wholeName = firstName + " "+ lastName;
			Console.WriteLine (wholeName);



			//**Values and Variables** 07_02 Numeric Data Types



			//Variables

			/*Numeric Data Types Integral Numbers
			sbyte  -signed byte
			sbyte  -128 to 127,
			byte   -0 to 255,
			short  -32768 to 32767, 
			ushort -0 to 65,535 
			int    -0 to 4,294,967,295
			uint   -2,147,483,648 to 2,147,483
			long   -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
-			ulong  -0 to 18,446,744,073,709,551,615
			char   -0 to 65535
			float  -1.5 x 1045 to 3.4 x 1038
			double -5 x 10324 to 1.7 x 10308
			decimal-1028 to 7.9 x 1028 
			bool   - true or false
			*/

			sbyte exSbyte = 127;
			Console.WriteLine (exSbyte);

			short exShort = 32767;
			Console.WriteLine (exShort);

			int exInt = 6813800;
			Console.WriteLine (exInt);

			//Larger data types use more memory

			long exLong = 233644577111112715;
			Console.WriteLine (exLong);



			//**Values and Variables** 07_03 Variables Decimal Type



			double exDouble = 57.8138;
			Console.WriteLine (exDouble);

			float exFloat = 36.8138f;
			Console.WriteLine (exFloat);

			decimal exDecimal = 71.8138m;
			Console.WriteLine (exDecimal);

			//use decimal for money




			//**Values and Variables** 07_04 Variables Unsigned Type




			//Sign vs. Unsigned 

			//Unsigned - only positive values

			byte exByte = 245;
			Console.WriteLine (exByte);

			ushort exUshort = 44023;
			Console.WriteLine (exUshort);

			uint exUlong = 2336445771;
			Console.WriteLine (exUlong);

			//byte 0-255, ushort 0-65535, uint, 0 4,294967295
			//ulong 0-18,446,744,073,709,551,615



			//**Values and Variables** 07_05 Arrays



			//Arrays are signified by []
			//datatype arrayName = new datatype[size of the array];

			//Create the arrary - Declare the array
			int [] bills = new int[3];

			//Fill the arrary - defining the arrary
			//arraryName[index#] = value;
			//Index # always start with zero!
			bills[0] = 230;
			bills [1] = 360;
			bills [2] = 5700;

			Console.WriteLine ("The water bill for this month is $"+ bills [1]);
			Console.WriteLine ("The the electric was $"+ bills [0]);
			int totalBills = bills [0] + bills [1] + bills [2];
			Console.WriteLine ("The total bills for the month is $"+totalBills);

			//Declare and Define an array in one step
			//data = [] arrary arrayName = new string[] {value1. value2, value3, etc)
			string [] fruits = new string[]{"apple","pear","banana","grapes"};

			Console.WriteLine (fruits[2]);
			Console.WriteLine (fruits[1]);
			Console.WriteLine (fruits[0]);

			//To find the numbers of variables in an arrary
			//length properties
			//dotsyntax - "use a period"
			Console.WriteLine(fruits.Length);

			//change any value inside an arrary
			//once changed it stays changed

			//variable name = new value
			fruits[0] = "kiwi";

			Console.WriteLine (fruits[0]);



			//**Values and Variables** 07_06 Sequential Coding



			//Declare the variable
			string myPet;

			//Define the variable
			//I bought a cat
			myPet = "Cat";
			//Print out what my pet currently is
			Console.WriteLine ("My pet currently is a " + myPet);

			//Variable can only hold one value at a time, unlike an arrary

			//redefine the variable
			//Got a new pet "dog";
			myPet = "Dog";

			//Print out what my pet currently is
			Console.WriteLine ("My pet currently is a " + myPet);

			//redefine the variable
			//Got a new pet "dog";
			myPet = "Monkey";

			//Print out what my pet currently is
			Console.WriteLine ("My pet currently is a " + myPet);



			//**Expressions** 08_01 Basic Expressions



			//Sequential Coding
			//"line by line"
			//Declare and define variable
			int a =2;
			//Change the value of a permanently
			a= a + 3;

			Console.WriteLine (a);

			//creat a new variable and base it on a different variable
			int b = a+3;

			Console.WriteLine (b);
			Console.WriteLine (a); 

			//Expression that finds out age
			//We need current year
			int currentYear = 2015;

			//born year
			int yearBorn = 1981;

			//Simple subtraction
			//Create a variable to hold the age
			int age = currentYear-yearBorn;

			Console.WriteLine ("My current age is "+age);



			//**Expressions** 08_02 math OPERATORS



			// + addition - concatenation when dealing with text strings
			// - subtraction
			// * multiplication 
			// / division

			//Area of a triangle
			//width * height / 2

			int width = 4;
			int height = 5;

			int areaTriangle = width * height / 2;
			Console.WriteLine (areaTriangle);

			//Add descriptive text of our final output (hard code)
			Console.WriteLine ("The area of a triangle with a width of "+width+" and a height of "+height+" is "+areaTriangle);



			//**Expressions** 08_03 Modulo



			//Modulo %
			//Give the remainder left over

			decimal normalDivision = 36 / 10m;
			Console.WriteLine (normalDivision);

			int remaninderVal = 36 % 4;
			Console.WriteLine (remaninderVal);

			// Tell if something is even or odd
			// %2 - if 1 then it is odd if 0 then is even

			int evenOrOdd = 36 % 2;
			Console.WriteLine (evenOrOdd);



			//**Expressions** 08_04 Orders of operations



			//Orders of Operations
			//PEMDOS - Parenthesis, Exponents, Multiply, Addition, Subtraction

			//Find the quiz average

			//Create variables for quiz values
			double quiz1 = 85;
			double quize2 = 100;
			double quize3 = 80;
			double quize4 = 90;

			//Average - with out parenthesis division is calculated 1st
			double average = (quiz1+quize2+quize3+quize4)/4;

			Console.WriteLine ("The of quiz average is "+average);

			//Excessive parenthesis is bad

			//Find the perimeter of a rectangle
			//2*length + 2*width

			int lenghtRectangle = 8;
			int widthRectangle = 6;

			int perimeterRect = 2 * lenghtRectangle + 2 * widthRectangle;
			Console.WriteLine (perimeterRect);



			//**Expressions** 08_05 Assignment OPERATORS



			//Assignment OPERATORS
			//
			/*
				= Assignment Operator - 'is'
				++ Addition of 1 - to the current value a++;  a= a+1;
				-- Subtraction of 1 - from the current value a= a-1;
				+= Addition Assignment Operator 	a+=4	 a= a+4;
				-+ Subtraction Assignment Operator	a-=4	 a= a-4;
				/= Division Assignment Operator a/=4; 		 a= a/4;
				*= Multiplication AssignmentOperator;		 a= a*4;
				*/

			//REDEFINES THE VARIABLE

			int toChange = 5; //		   (value is 5)
			toChange++; //   - toChange+1; (value is 6)
			toChange--; //   - toChange-1; (value is 5)
			toChange+=3; //  - toChange+3; (value is 8)
			toChange-=2; //  - toChange-2; (value is 6)
			toChange/=2; //  - toChange/3; (value is 3)
			toChange*=3; //  - toChange*4; (value is 9)

			//the long way**
			toChange = toChange / 3;

			Console.WriteLine (toChange);



			//**Conversions & Prompting** 09_01 Implicit Conversions



			//Converting Veriables

			/*3 types of conversions 
			1) Implicit - no special syntax is required, no data loss, 
			smaller to larger integral types
			2) Explicit 
			3)Conversion with helper class
			*/

			//Implicit Conversions
			//smaller to larger datatypes

			short num = 23456;
			Console.WriteLine (num);

			//implicitly convert
			int bigNum = num;
			Console.WriteLine (bigNum);



			//**Conversions & Prompting** 09_02 Explicit Conversion



			//Explicit Conversions
			//Beware of data loss [casting]

			double x = 1234.56;
			Console.WriteLine (x);

			int xConverted = (int)x;
			Console.WriteLine (xConverted);

			//Convert a large number to an sbyte
			int z = 130;
			sbyte zConverted = (sbyte)z;

			Console.WriteLine (z);
			Console.WriteLine (zConverted);



			//**Conversions & Prompting** 09_03_Helper Classes



			//Helper Class

			//Convert Class

			string stringValue = "57";

			//Try to multiply by 2

			//Does not work
			//int multiplied = stringValue*2;

			//Convert string to Number then multiply
			int multiplied = Convert.ToInt32(stringValue);
			multiplied = multiplied * 2;
			multiplied *= 2;

			Console.WriteLine (multiplied);

			//Parse - Converts a string into a dfferent datatype


			//Create a string variable

			string salary = "17144400";

			//Parse the string and pull out the integer

			int salaryInt = int.Parse (salary);

			Console.WriteLine (salaryInt);

			//Divide salary by 2
			salaryInt = salaryInt/2;

			Console.WriteLine (salaryInt);



			//**Conversions & Prompting** 09_04 Prompting



			//ReadLine method of the console
			//reads the next line in the console and returns the text back to your string
			//ONLY returns a string
			//Ask the user their name
			//Ask the question, then listen for the responce

			Console.WriteLine ("Please type your name and press enter.");

			//Listen for the answer
			//Creat a variable to "catch" the return text string
			string userName = Console.ReadLine();

			//Say hello to the user

			Console.WriteLine ("Hello " + userName + " welcome to our program!");

			//Calculate the perimeter of a rectangle
			//width *2 + lenght*2

			//Ask the user for with and lenght

			Console.WriteLine ("Find the parimeter of a rectangle. \r\nEnter a width and press enter:");

			//Listen for answer
			string widthString = Console.ReadLine();

			//Convert the string to an int number datatype
			double widthNumber = double.Parse(widthString);

			//Ask the user for a lenght

			Console.WriteLine("Next enter a lenght");

			//Listen for answer
			string lenghtString = Console.ReadLine ();
			//Convert the string to an int number datatype
			double lenghtNumber = double.Parse(lenghtString);


			double parimeterRectangle = widthNumber * 2 + lenghtNumber * 2;


			//Add discritive text
			Console.WriteLine ("The parimeter of the rectangle is: "+parimeterRectangle);

			//if user types a decimal there is an error
		}
	}
}
