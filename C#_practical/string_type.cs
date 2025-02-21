using System;
public class string_type
{
	public static void Main()
	{
		Console.WriteLine("Enter to your name:");
		string name=Console.ReadLine();
		Console.WriteLine("Enter to your surname:");
		string sername=Console.ReadLine();
		sername+=name;
		Console.WriteLine(sername);
		Console.ReadKey();
	}
}