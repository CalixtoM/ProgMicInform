using System;

class Program {
    static void Main(string[] args) {
        double n1, n2, n3, m;
        Console.Write("digite a nota 1 ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("digite a nota 2 ");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("digite a nota 3 ");
        n3 = Convert.ToDouble(Console.ReadLine());
        m = (n1*2+n2*3+n3*5)/10;
        Console.Write("Media: " +m);
    }
}