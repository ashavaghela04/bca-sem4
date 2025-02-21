class nonst_method
{
	static void check()
	{
		System.out.println("non static");
	}
	public static void main(String [] args)
	{
		nonst_method nonsta = new nonst_method();
		nonsta.check();
		System.out.println("My first non static java program");
	}
}