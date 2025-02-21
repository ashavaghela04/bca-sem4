using System;
namespace array
{
	class string_array
	{
		public static void Main()
		{
		
			Console.Write("Enter row size=");
			int  size=Convert.ToInt32(Console.ReadLine());
			string [] arr=new string[size];
		
			for(int i=0;i<arr.Length;i++)
			{
				Console.Write("a[{0}]=",i);
				arr[i]=Console.ReadLine();
			}
			Console.WriteLine("string value.....");
			foreach(string str in arr)
			{
				Console.WriteLine(str);
			}
			Console.ReadLine();
		}
	}
}