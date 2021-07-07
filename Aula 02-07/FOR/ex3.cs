using System;

class Program {
    static void Main(string[] args) {
        
        int i;
        double n, s;
        s = 0;
        for(i=1; i<=10; i++){
            Console.Write("Digite um número: ");
            n = Convert.ToDouble(Console.ReadLine());
            if(n > 10 ){
                s = s+n;
            }
        }
        Console.Write("Resultado da soma de números maiores que 10: "+s);
    }
}