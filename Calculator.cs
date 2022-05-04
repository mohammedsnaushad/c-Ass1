using System;
public class calc
{
    public static void Main()
    {
        int x;
        int y;
        Console.WriteLine("Enter the value of x");
        x=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of y");
        y=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your choice");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Substraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");
        int ch=Convert.ToInt16(Console.ReadLine());
        switch(ch)
        {
            case 0: Console.WriteLine("Sum of two numbers":+(x + y));break;
            case 1: Console.WriteLine("Difference of two numbers":+(x - y)); break;
            case 0: Console.WriteLine("Sum of two numbers":+(x + y)); break;


        }


    }
}
