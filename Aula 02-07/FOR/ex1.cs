using System;

class Program {
    static void Main(string[] args) {
        
        int i, l;
        double n, r;

        Console.Write("Digite o número: ");
        n = Convert.ToDouble(Console.ReadLine());

        for(i=1; i<=10; i++ ){
            l = i+3;
            r = n*i;
            Console.SetCursorPosition(4, l);
            Console.Write(n+" x "+i+" = "+r);
        }
    }
}