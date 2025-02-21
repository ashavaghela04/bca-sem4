class enum_data
{
	enum depart{bca,mca,msc};
	public static void main(String [] args)
	{
		depart variable=depart.bca;
		System.out.println(variable);
		Getdata(variable);
	}
	public static void Getdata(depart a)
	{
		System.out.println(a);		
	}

}