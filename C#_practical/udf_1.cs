using System;
public class udf_1
{
    int id;
    string name;
    void display()
    {
        Console.WriteLine("Id="+id);
        Console.WriteLine("Name="+name);
    }
    public static void Main(string [] args)
    {
        udf_1 s1=new udf_1();
        udf_1 s2=new udf_1();
        s1.id=101;
        s1.name="Vaghela Asha";
        s2.id=102;
        s2.name="Khunt Yashavi";
        s1.display();
        s2.display();
    }

}
