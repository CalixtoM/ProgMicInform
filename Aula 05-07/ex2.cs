using System;

class Program {
    static int vtri(double n1, double n2, double n3){
        if((n1+n2)>n3){
            int res = 1;
            return res;

        }
        else{
            int res = 0;   
            return res;

        }

    }

    static void Main(string[] args) {
        double n1, n2, n3;

        Console.Write("Insira lado 1: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira lado 2: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira lado 3: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        if(vtri(n1, n2, n3) == 1){
            Console.Write("Representa");
        }
        else{
            Console.Write("não Representa");   
        }
    }
}