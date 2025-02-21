public class num_sum
{
	public static void main(String[] args)
	{
		// decimalLiterals...
			int decimalLiterals_1=10;
			int decimalLiterals_2=10;
			decimal.sum(decimalLiterals_1,decimalLiterals_2);
		//binary...	
			int binaryLiterals_1=0b110010;
			int binaryLiterals_2=0b110010;
			bianry.sum(binaryLiterals_1,binaryLiterals_2);
		//octal....
			int octalalLiterals_1=0144;
			int octalalLiterals_2=0144;
			octal.sum(octalalLiterals_1,octalalLiterals_2);
		//hexa...
			int hexLiterals_1=0x64;
			int hexLiterals_2=0x64;
			hexa.sum(hexLiterals_1,hexLiterals_2);
	}
}
 class decimal
{
	public static void sum(int decimal_1,int decimal_2)
	{
		System.out.println(" Decimal number 1=" +decimal_1);
		System.out.println(" Decimal number 2=" +decimal_2);
		System.out.println("Sum of Decimal number=" +(decimal_1+decimal_2));
	}
}
 class bianry
{
	public static void sum(int bianry_1,int bianry_2)
	{
		System.out.println(" binary number 1=" +bianry_1);
		System.out.println("binary number 2=" +bianry_2);
		System.out.println("Sum of Binary number=" +(bianry_1+bianry_2));
	}
}
 class octal
{
	public static void sum(int octala_1,int octala_2)
	{
	    System.out.println("octal number 1=" +octala_1);
		System.out.println("octal number 2=" +octala_2);
		System.out.println("Sum of Octal number=" +(octala_1+octala_2));
	}
}
 class hexa
{
	public static void sum(int hexa_1,int hexa_2)
	{
		System.out.println("Hexa number 1=" +hexa_1);
		System.out.println("Hexa number 2=" +hexa_2);
		System.out.println("Sum of Hexadecimal number=" +(hexa_1+hexa_2));
	}
}
