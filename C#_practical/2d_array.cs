using System;
class 2d_array
{
	public static void Main()
	{
		
		Console.Write("Enter row size=");
		int  r=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter row size=");
		int  c=Convert.ToInt32(Console.ReadLine());

		int [,] arr=new int[r,c];
		
		for(int i=0;i<arr.GetLength(0);i++)
		{
			for(int j=0;j<arr.GetLength(1);j++)
			{
				Console.Write("a[{0},{1}]=",i,j);
				arr[i,j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		Console.Write("array value.....");
		for(int i=0;i<arr.GetLength(0);i++)
		{
			for(int j=0;j<arr.GetLength(1);j++)
			{
				Console.WriteLine("a[{0},{1}]={2}",i,j,arr[i,j]);
			}
		}
		Console.ReadLine();
	}
}