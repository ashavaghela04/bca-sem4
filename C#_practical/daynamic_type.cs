using System;
public class daynamic_type
{
	public static void Main()
	{
		dynamic msg="Hello!";
		Console.WriteLine(msg);
		msg=Console.ReadLine();
		Console.WriteLine(msg);
		Console.ReadKey();
	}
}