using System;

namespace Application
{
     class SimpleInterest
    {
        static void Main(string[] args)
        {
            int p= int.Parse(Console.ReadLine());
			int r = int.Parse(Console.ReadLine());
			int n = int.Parse(Console.ReadLine());
            int si = p * r * n / 100;
            Console.WriteLine("Principal amount is : " + (p));
			Console.WriteLine("Rate of interest is : " + (r));
			Console.WriteLine("Number of years is : " + (n));
			Console.WriteLine("Simple Interest is : " + (si));

		}
    }
}
