using System;  
public class prime
{  
    public static void Main() 
	{   
        int num,i;
        //Calculate and display the Prime number  
		Console.WriteLine(" prime number...");  
        for (num = 2; num <= 100; num++) 
		{  
			int cou=0;  
            for (i = 2; i <=100; i++) 
			{  
                if (num%i==0) 
				{
					cou++; 
                }  
            }  
            if (cou<=2) 
			{  
				Console.WriteLine(num);
            }  
        }  
        Console.ReadKey();  
    }  
}  