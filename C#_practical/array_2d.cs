using System;
class array_2d
{
	public static void Main()
	{
		
		Console.Write("Enter row size=");
		int  r=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter colum size=");
		int  c=Convert.ToInt32(Console.ReadLine());
		int sum=0;
		int [,] arr=new int[r,c];
		
		for(int i=0;i<arr.GetLength(0);i++)
		{
			for(int j=0;j<arr.GetLength(1);j++)
			{
				Console.Write("a[{0},{1}]=",i,j);
				arr[i,j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		Console.WriteLine("array value.....");
		for(int i=0;i<arr.GetLength(0);i++)
		{
			for(int j=0;j<arr.GetLength(1);j++)
			{
				Console.Write("  "+arr[i,j]);
			}
			Console.Write("\n");
		}
		for(int i=0;i<arr.GetLength(0);i++)
		{
			for(int j=0;j<arr.GetLength(1);j++)
			{
				sum+=arr[i,j];
			}
			Console.WriteLine(" sum of a[{0}]={1}",i,sum);
		}
		Console.ReadLine();
	}
}