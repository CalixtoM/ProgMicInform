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
            Console.ForegroundColor = ConsoleColor.Red;
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
            Console.WriteLine("Exercicio 2!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(4, 5);
            double tempc, tempk;
            Console.Write("Digite a temperatura em Celsius: ");
            tempc = Convert.ToDouble(Console.ReadLine());
            tempk = (tempc+273.15);
            Console.SetCursorPosition(4, 8);
            Console.Write("Temperatura em Kelvin: "+tempk);
        }   
    }