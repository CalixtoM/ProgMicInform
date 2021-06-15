using System;

class Program {
    static void Main(string[] args) {
		double n1, n2, n3, med;
		Console.Write("digite um numero ");
		n1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("digite um numero ");
		n2 = Convert.ToDouble(Console.ReadLine());
		Console.Write("digite um numero ");
		n3 = Convert.ToDouble(Console.ReadLine());
		med = (n1+n2+n3)/3;
		Console.Write("Media: " +med);
    }
}