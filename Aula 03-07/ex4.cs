using System;

class Program {

    static void Main(string[] args) {

        double n, s;
        s = 0;
        do{
            Console.Write("Escreva um número: ");
            n = Convert.ToDouble(Console.ReadLine());
            s = s+n;

        }while(n != 0 );

        Console.Write("Soma dos números digitados: "+s);

    }
}