using System;

class Program {

    static void Main(string[] args) {

        double n, s;
        string c = "n";
        s = 0;
        do{
            Console.Clear();
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
            
            Console.WriteLine("Média: "+(s/4));

            Console.WriteLine("Digite 's' caso deseja recomeçar: ");
            c = Console.ReadLine();
        }
        while(c == "s");

    }
}