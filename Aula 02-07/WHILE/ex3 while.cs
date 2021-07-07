using System;

class Program {
    static void Main(string[] args) {
        
        int i, n, c;
        i = 1;
        c = 0;
        
        while(i<=10){
            Console.Write("Escreva um numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            if(n < 0){
                c++;
            }
            i++;
        }
        Console.Write(c+" números negativos");
    }
}