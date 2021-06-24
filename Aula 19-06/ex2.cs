using System;

class Program {
    static void Main(string[] args) {
        double a, b, b2, c, delta, delta2, x1, x2;
        Console.Write("Digite o valor de a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o valor de b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o valor de c: ");
        c = Convert.ToDouble(Console.ReadLine());
        b2 = Math.Pow(b, 2);
        delta = b2-4*a*c;
        delta2 = Math.Sqrt(delta);
        x1 = (((b*(-1))+delta2)/(2*a));
        x2 = (((b*(-1))-delta2)/(2*a));
        Console.Write("Delta: "+delta+ ", x1: "+x1+ ", x2: " +x2);
        Console.ReadKey();
    }
}