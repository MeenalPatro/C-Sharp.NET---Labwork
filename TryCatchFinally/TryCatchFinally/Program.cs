using System;

class Program
{
	static void Main(string [] args)
	{
		try
		{
			Console.Write("Enter a number: ");
			int num = Convert.ToInt32(Console.ReadLine());

			int result = 50 / num;

			Console.WriteLine("Result: " + result);
		}
		catch (DivideByZeroException ex)
		{
			Console.WriteLine("Error: Cannot divide by zero.");
		}
		catch (FormatException ex)
		{
			Console.WriteLine("Error: Invalid input.");
		}
		finally
		{
			Console.WriteLine("This block always executes.");
		}

		Console.WriteLine("Program continues...");
	}
}