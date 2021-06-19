using System;

class Program {
    static void Main(string[] args) {
        double b, a, ar;
        Console.Write("digite base ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("digite altura ");
        a = Convert.ToDouble(Console.ReadLine());
        ar = (b*a);
        Console.Write("Area: " +ar);
    }
}