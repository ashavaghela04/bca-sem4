using System;
class loop
{
	public static void Main()
	{
		int b=1;
		for(int b;b<=5;b++)
		{
			Console.Write("\nvalue of A is " + b);
		}
		while(b>=5)
		{
			Console.Write("\nvalue of A is " + b);
			b--;
		}
		Console.Read();
	}
}