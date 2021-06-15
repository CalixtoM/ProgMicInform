using System;

class Program {
    static void Main(string[] args) {
		double n1, n2, soma, mult, sub, div;
		Console.Write("digite um numero ");
		n1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("digite um numero ");
		n2 = Convert.ToDouble(Console.ReadLine());
		soma = n1+n2;
		mult = n1*n2;
		sub = n1-n2;
		div = n1/n2;
		Console.Write("Resultados: soma = " +soma+ ", subtracao = " +sub+ ", multiplicacao = " +mult+ ", divisao = " +div);
    }
}