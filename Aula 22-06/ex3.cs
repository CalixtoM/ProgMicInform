using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
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
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(24, 3);
            Console.WriteLine("Exercicio 3!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 5);
            double tempf, tempc;
            Console.Write("Digite a temperatura em fahrenheit: ");
            tempf = Convert.ToDouble(Console.ReadLine());
            tempc = (tempf - 32)*(0.555555556);
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("A temperatura em Celsius é: "+Math.Round(tempc, 2));
        }   
    }