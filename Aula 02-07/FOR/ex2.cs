using System;

class Program {
    static void Main(string[] args) {
        
        int i, l;
        double n;

        Console.Write("Digite o número: ");
        n = Convert.ToDouble(Console.ReadLine());

        if(n>0){
            for(i=1; i<=n; i++ ){
                l = i+3;
                Console.SetCursorPosition(4, l);
                Console.Write(i);
            }
        }
        else{
            Console.Write("O Número digitado é menor que zero :( ");
        }
    }
}