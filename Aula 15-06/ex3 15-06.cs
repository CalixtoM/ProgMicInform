using System;

class Program {
    static void Main(string[] args) {
		int atual, nasc, id;
		Console.Write("digite o ano do seu nascimento: ");
		nasc = Convert.ToInt32(Console.ReadLine());
		Console.Write("digite o ano atual: ");
		atual = Convert.ToInt32(Console.ReadLine());
		id = atual - nasc;
		Console.Write("Você completa: " +id+ " anos em 2021");
    }
}