using System;

namespace hourly_pay_checker
{
	class MainClass
	{
		/*
		 * Write a program that prompts the user for an hourly pay rate. If the value entered is less than $7.50
		 * or greater than $49.00, display an error message, otherwise display a message indicating that the rate is okay.
		 */

		public static void Main(string[] args)
		{
			Console.WriteLine("Enter an hourly wage");
			double userWage = double.Parse(Console.ReadLine());

			if (userWage > 7.50 && userWage < 49.00)
			{
				Console.WriteLine("{0:c} is a perfect wage", userWage);
			}
			else
			{
				Console.WriteLine("{0:c} is way off the mark", userWage);
			}
		}
	}
}
