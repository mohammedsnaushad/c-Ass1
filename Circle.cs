using System;
public class Crc
{
    public static void Arper(ref double r)
    {
        double area;
        double permtr;
        area = Math.PI * r * r;
        permtr = 2 * Math.PI * r;
        Console.WriteLine("Area of the circle :" + area);
        Console.WriteLine("Perimetre of Circle:" + permtr);
    }
    public static void Main()
    {
        Console.WriteLine("Enter the radius of the circle");
        double r= Convert.ToDouble(Console.ReadLine());
        Arper(ref r);
    }
}
