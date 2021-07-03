// 2 – Crie um programa que permite que o usuário digite o valor de um 
// numero qualquer, verificar se o numero é múltiplo de 3 e de 7 ao 
// mesmo tempo, caso seja imprimir na tela “Múltiplo de 3 e 7”, caso 
// não imprimir “Não é múltiplo”.

using System;

class Program {
    static void Main(string[] args) {
        

        int n;
        Console.Write("Digite um número: ");
        n = Convert.ToInt32(Console.ReadLine());

        if((n % 3 == 0) && (n % 7 == 0)){
        	Console.ForegroundColor = ConsoleColor.Green;
        	Console.Write("Multiplo de 3 e 7");
        }
        else{
        	Console.ForegroundColor = ConsoleColor.Red;
        	Console.Write("Não é multiplo");
        }

    }
}