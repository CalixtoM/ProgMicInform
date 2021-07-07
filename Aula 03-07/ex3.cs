using System;

class Program {

    static void Main(string[] args) {

        double n;

        do{
            Console.Write("Escreva um número: ");
            n = Convert.ToDouble(Console.ReadLine());

        }while(n > 1 );
        Console.Write("Fim");

    }
}