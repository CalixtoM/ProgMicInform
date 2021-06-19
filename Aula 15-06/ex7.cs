using System;

class Program {
    static void Main(string[] args) {
        int a, m, d, t;
        Console.Write("digite anos ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("digite meses ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.Write("digite dias ");
        d = Convert.ToInt32(Console.ReadLine());
        t = (a*365)+(m*30)+d;
        Console.Write("Dias: " +t);

    }
}