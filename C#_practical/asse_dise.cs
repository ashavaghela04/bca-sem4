using System;
class asse_dise
{
	public static void Main()
	{
		Console.WriteLine("Enter your value:");
		int a = Convert.ToInt32(Console.ReadLine());
		//Console.WriteLine(a);
		Console.WriteLine("assending order....");
		for(int b=1;b<=a;b++)
		{
			Console.WriteLine(b);
		}
		Console.WriteLine("disending order....");
		while(a>=1)
		{
			Console.WriteLine(a);
			a--;
		}
		Console.Read();
	}
}