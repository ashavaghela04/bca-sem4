using System;
interface intr_face
{
    void rules();
}
class parent
{
    public void parent_fun()
    {
        Console.WriteLine("parent function call");
    }
}
class child : parent , intr_face 
{
    public void rules()
    {
        Console.WriteLine("interface class function call");
    }
    public void child_fun()
    {
        Console.WriteLine("child function call");
    }
}
class main_class
{
    public static void Main()
    {
       // parent p=new parent();
        //p.parent_fun();
        child p=new child();
        p.rules();
        p.parent_fun();
        p.child_fun();
    }
}