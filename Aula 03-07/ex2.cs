using System;

class Program {

    static void Main(string[] args) {

        double n, s;
        s = 0;
        do{
            Console.Write("Escreva a 1ª nota: ");
            n = Convert.ToDouble(Console.ReadLine());
            if(n>= 0 && n<=10){
                s = n;
            }    

        }while(n < 0 || n > 10);
        do{
            Console.Write("Escreva a 2ª nota: ");
            n = Convert.ToDouble(Console.ReadLine());

            if(n>= 0 && n<=10){
                s = s + n;
            }

        }while(n < 0 || n > 10);
        do{
            Console.Write("Escreva a 3ª nota: ");
            n = Convert.ToDouble(Console.ReadLine());

            if(n>= 0 && n<=10){
                s = s + n;
            }

        }while(n < 0 || n > 10);
        do{
            Console.Write("Escreva a 4ª nota: ");
            n = Convert.ToDouble(Console.ReadLine());

            if(n>= 0 && n<=10){
                s = s + n;
            }

        }while(n < 0 || n > 10);
        
        Console.Write("Média: "+(s/4));

    }
}