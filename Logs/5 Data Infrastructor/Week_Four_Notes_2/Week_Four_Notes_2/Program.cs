using System;

namespace Week_Four_Notes_2
{
	//main class
	class MainClass
	{
		//main method
		public static void Main (string[] args)

		//< visibility (public, private, [protected, internal] modifier - static) >
		//< return type (any datatype can be returned, if none returned use 'void) > 
		//< name (starts with a capital letter, no spaces, camel case) >
		//< parameters (use parenthesis, can be left blank) >
		//
		//< Function Call (FunctionName (<arguments> [values passed to function]) >

		{



			//**Functions** 16_01_FunctionsOverview



			//reusable code type = function = method
			//variables store values, functions store blocks of code



			//**Functions** 16_02_FunctionStructure



			//< visibility (public, private, [protected, internal] modifier - static) >
			//< return type (any datatype can be returned, if none returned use 'void) > 
			//< name (starts with a capital letter, no spaces, camel case) >
			//< parameters (use parenthesis, can be left blank) >
			//
			//< Function Call (FunctionName (<arguments> [values passed to function]) >

			Console.WriteLine ("Before function call.");
			//create function call for PrintName method
			PrintName ();
			Console.WriteLine ("After function call.");

			PrintName ();
			//calls method
			PrintMore ();
		


			//**Functions** 16_03_VariableScope


			//variables created inside a method do not cary over to other methods (includeing main method)
			string userName = "Nate Dog";

			Console.WriteLine (userName);



			//**Functions** 16_04_ReturnValue



			int width1 = 10;
			int height1 = 5;

			int results = calcArea (width1, height1);
			Console.WriteLine (results);



			//**Functions** 16_05_ArgumentsParameter



			//int width1 = 10;
			//int height1 = 5;

			int results2 = calcArea (71,23);
			Console.WriteLine (results2);

			//**Functions** 16_06_BringingItAllTogether





		}

		public static void PrintName ()
		{

			//create variable that holds user name
			//variables created inside a method are 'scoped' to it
			string userName = "Tommy";

			//Code that will run when method is called
			Console.WriteLine ("Welcome to Functions " +userName+"!");

		}

		public static void PrintMore ()
		{

			//Code that will run when method is called
			Console.WriteLine ("More functions!");

		}

		public static int calcArea(int w,int h){


			//int width = 6;
			//int height = 7;

			//calculate the area of a rectangle
			//int area = width*height;
			int area = w-h;


			//return the area
			return area;
			
		}

	}
}
