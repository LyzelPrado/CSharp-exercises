using System;

public class CreatingClass
{
    string sClassName = "Your Class Name is ";
    
    public CreatingClass (string sInputString)
    {
        sClassName = sClassName + sInputString;
    }
    
    public void printClassName()
    {
        Console.WriteLine("{0}", sClassName);
    }
    
}

public class ClassDemo
{
    public static void Main()
    {
        CreatingClass myClass = new CreatingClass("ClassDemo.");
        myClass.printClassName();
    }
}