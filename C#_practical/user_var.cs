using System;
class user_var
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter your age:");
		float age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Your age is: " + age);
		Console.WriteLine("Enter username:");
		string userName = Console.ReadLine();
		Console.WriteLine("Username is: " + userName);
	  Console.Read();
	}
}
