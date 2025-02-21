using System;
class jagged_arr
{
	public static void Main()
	{
		int [][] j_arr=new int[3][];
		j_arr[0]=new int [2];
		j_arr[1]=new int [3];
		j_arr[2]=new int [4];
		//Console.WriteLine("array row size=" + j_arr.GetLength(0));
		//Console.WriteLine("array col size=" + j_arr.GetLength(1));
		//Console.WriteLine("j_arr[][]={2}" + j_arr[0].Length);

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
				Console.WriteLine("a[{0},{1}]={2}",i,j,j_arr[i][j]);
			}
		}
		Console.ReadLine();
	}
}