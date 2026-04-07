using System;

class Program
{
	static void Main(string [] args)
	{
		try
		{
			Console.Write("Enter a number: ");
			int num = Convert.ToInt32(Console.ReadLine());

			int result = 100 / num;

			Console.WriteLine("Result: " + result);
		}
		catch (DivideByZeroException ex)
		{
			Console.WriteLine("Error: Cannot divide by zero.");
			Console.WriteLine("Message: " + ex.Message);
		}
		catch (FormatException ex)
		{
			Console.WriteLine("Error: Invalid input format.");
			Console.WriteLine("Message: " + ex.Message);
		}
	}
}