

using System;

class Program {
    static void Main(string[] args) {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.SetCursorPosition(2, 2);
        Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
        Console.SetCursorPosition(2, 3);
        Console.WriteLine("║                                                       ║");
        Console.SetCursorPosition(2, 4);
        Console.WriteLine("║                                                       ║");
        Console.SetCursorPosition(2, 5);
        Console.WriteLine("║                                                       ║");
        Console.SetCursorPosition(2, 6);
        Console.WriteLine("║                                                       ║");
        Console.SetCursorPosition(2, 7);
        Console.WriteLine("║                                                       ║");
        Console.SetCursorPosition(2, 8);
        Console.WriteLine("║                                                       ║");
        Console.SetCursorPosition(2, 9);
        Console.WriteLine("║                                                       ║");
        Console.SetCursorPosition(2, 10);
        Console.WriteLine("║                                                       ║");
        Console.SetCursorPosition(2, 11);
        Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(24, 3);
        Console.WriteLine("Exercicio 2!");
        Console.ForegroundColor = ConsoleColor.White;
        int opcao;
        double n1, n2, r;
        Console.SetCursorPosition(4, 5);
        Console.Write("1 – Adição. \n");
        Console.SetCursorPosition(4, 6);
        Console.Write("2 – Subtração. \n");
        Console.SetCursorPosition(4, 7);
        Console.Write("3 – Multiplicação. \n");
        Console.SetCursorPosition(4, 8);
        Console.Write("4 – Divisão. \n");
        Console.SetCursorPosition(25, 10);
        Console.Write("( )");
        Console.SetCursorPosition(4, 10);
        Console.Write("Escolha uma operação:");
        Console.SetCursorPosition(26, 10);
        opcao = Convert.ToInt32(Console.ReadLine());
        switch(opcao) {
            case 1:
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 4);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 5);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 6);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 7);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 8);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 9);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 10);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 11);
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(26, 3);
                Console.WriteLine("Adição!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(4, 7);
                Console.Write("Digite o primeiro numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(4, 8);
                Console.Write("Digite o segundo numero: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                r = n1+n2;
                Console.SetCursorPosition(12, 10);
                Console.Write("O resultado dessa conta é: "+r);

            break;

            case 2:
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 4);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 5);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 6);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 7);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 8);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 9);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 10);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 11);
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(26, 3);
                Console.WriteLine("Subtração!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(4, 7);
                Console.Write("Digite o primeiro numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(4, 8);
                Console.Write("Digite o segundo numero: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                r = n1-n2;
                Console.SetCursorPosition(12, 10);
                Console.Write("O resultado dessa conta é: "+r);
            break;

            case 3:
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 4);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 5);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 6);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 7);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 8);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 9);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 10);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 11);
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(22, 3);
                Console.WriteLine("Multiplicação!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(4, 7);
                Console.Write("Digite o primeiro numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(4, 8);
                Console.Write("Digite o segundo numero: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                r = n1*n2;
                Console.SetCursorPosition(12, 10);
                Console.Write("O resultado dessa conta é: "+r);

            break;

            case 4:
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 4);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 5);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 6);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 7);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 8);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 9);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 10);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 11);
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(26, 3);
                Console.WriteLine("Divisão!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(4, 7);
                Console.Write("Digite o primeiro numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(4, 8);
                Console.Write("Digite o segundo numero: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                r = n1/n2;
                Console.SetCursorPosition(12, 10);
                Console.Write("O resultado dessa conta é: "+r);

            break;

            default:
                Console.SetCursorPosition(4, 9);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Opção Inválida");
                break;
        }
    }
}