using System;

class Program {

    static void Main(string[] args) {

        double n;

        do{
            Console.Write("Escreva um número: ");
            n = Convert.ToDouble(Console.ReadLine());

        }while(n % 2 != 0);
        Console.Write("O número digitado foi: "+ n);

    }
}