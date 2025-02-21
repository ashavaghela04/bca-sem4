using System;
class unboxing
{
	public static void Main()
	{
		
		object obj=Convert.ToInt32(Console.ReadLine());
		int i=(int) obj;
		Console.WriteLine(obj);
		Console.WriteLine(i);
		Console.ReadLine();
	}
}