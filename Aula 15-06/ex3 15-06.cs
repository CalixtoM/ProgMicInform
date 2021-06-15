using System;

class Program {
    static void Main(string[] args) {
		double nasc, id;
		Console.Write("digite o ano do seu nascimento: ");
		nasc = Convert.ToDouble(Console.ReadLine());
		id = 2021 - nasc;
		Console.Write("Você completa: " +id+ " anos em 2021");
    }
}