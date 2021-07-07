

using System;

class Program {
    static double adicao(double n1, double n2) {
        
        double r = n1+n2;
        
        
        return r;
    }

    static double sub(double n1, double n2) {
        
        double r = n1-n2;
        
        
        return r;
    }

    static double multi(double n1, double n2) {
        
        double r = n1*n2;
        
        
        return r;
    }

    static double div(double n1, double n2) {
        
        double r = n1/n2;
        
        
        return r;
    }

    static void Main(string[] args) {


        int opcao;
        double n1, n2;
        Console.SetCursorPosition(4, 3);
        Console.Write("1 – Adição. \n");
        Console.SetCursorPosition(4, 4);
        Console.Write("2 – Subtração. \n");
        Console.SetCursorPosition(4, 5);
        Console.Write("3 – Multiplicação. \n");
        Console.SetCursorPosition(4, 6);
        Console.Write("4 – Divisão. \n");
        Console.SetCursorPosition(4, 8);
        Console.Write("Escolha uma operação: ");
        opcao = Convert.ToInt32(Console.ReadLine());
        switch(opcao) {
            case 1:
            Console.Clear();
                Console.Write("Digite o primeiro numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Resultado da operação: "+adicao(n1, n2));

            break;

            case 2:
                Console.Clear();
                Console.Write("Digite o primeiro numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Resultado da operação: "+sub(n1, n2));

            break;

            case 3:
                Console.Clear();
                Console.Write("Digite o primeiro numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Resultado da operação: "+multi(n1, n2));

            break;

            case 4:
                Console.Clear();
                Console.Write("Digite o primeiro numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Resultado da operação: "+div(n1, n2));

            break;
        }
    }
}