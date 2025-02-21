class multi_method
{
	static void check()
	{
		System.out.println(" non static");
	}
	void checktwo()
	{
		System.out.println("checktwo");
	}
	public static void main(String [] args)
	{
		multi_method nonsta = new multi_method();
		nonsta.check();
		nonsta.checktwo();
		System.out.println("My first non static java program");
	}
}