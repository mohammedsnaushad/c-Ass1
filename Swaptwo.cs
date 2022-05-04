using System;
public class Swp
{
    public static void Swap(ref double x,ref double y)
    {
        double temp;
        temp = x;
        x = y;
        y = temp;
    }
    public static void Main()
    {
        Console.WriteLine("Enter two numbers to swap");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        Swap(ref x,ref y);
        Console.WriteLine("After swapping :{0} , {1}",x,y);
    }


}

