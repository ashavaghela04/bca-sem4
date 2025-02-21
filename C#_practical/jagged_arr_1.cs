using System;
class jagged_arr_1
{
	public static void Main()
	{
		Console.Write("Enter row size=");
		int  row=Convert.ToInt32(Console.ReadLine());
		int [][] j_arr=new int[row][];
		for(int i=0;i<j_arr.Length;i++)
		{
			Console.Write("\n Enter array[{0}] colum= ",i);
			int  col=Convert.ToInt32(Console.ReadLine());
			j_arr[i]=new int[col];

		}
		for(int i=0;i<j_arr.Length;i++)
		{
			for(int j=0;j<j_arr[i].Length;j++)
			{
				Console.Write("a[{0},{1}]=",i,j);
				j_arr[i][j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		Console.WriteLine("array value.....");
		for(int i=0;i<j_arr.Length;i++)
		{
			for(int j=0;j<j_arr[i].Length;j++)
			{
				Console.Write("  "+j_arr[i][j]);
			}
			Console.Write("\n");
		}
		Console.ReadLine();
	}
}