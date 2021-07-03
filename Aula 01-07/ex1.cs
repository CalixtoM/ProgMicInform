//1 – Crie um programa que permita que o usuário digite o valor das vendas que executou neste mês, 
//imprimir na tela o premio que ganhou por estas vendas de acordo com os critérios abaixo:

//•Menor que R$ 1000,00 (Sem premio).
//•Maior igual a R$ 1000,00 e menor que R$ 3000,00 (premio de R$ 150,00).
//•Maior igual a R$ 3000,00 (premio de R$ 300,00).

using System;

class Program {
    static void Main(string[] args) {
        

		double v;

		Console.Write("Escreva o valor de vendas: ");
		v = Convert.ToDouble(Console.ReadLine());

		if(v < 1000){
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("Sem premios");
		}
		else if((v >= 1000.00) && (v < 3000.00)){
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("Premio de R$ 150.00");
		}
		else{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("Premio de 300.00");
		}

    }
}