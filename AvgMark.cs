using System;
public class mark
{
    public static void Main()
    {
        int a, b,c,d,e;
        Console.WriteLine("Enter the mark of first student:");
        a =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the mark of second student:");
        b =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the mark of third student:");
        c =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the mark of fourth student:");
        d =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the mark of fifth student:");
        e=Convert.ToInt32(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
            Console.WriteLine("The largest mark is : " + a);
        else if (b > a && b > c && b > d && b > e)
            Console.WriteLine("The largest mark is : " + b);
        else if (c > a && c > b && c > d && c > e)
            Console.WriteLine("The largest mark is : " + c);
        else if (d > a && d > b && d > c && d > e)
            Console.WriteLine("The largest mark is : " + d);
        else
            Console.WriteLine("The largest mark is : " + e);
    }
}
