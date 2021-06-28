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
            Console.ForegroundColor = ConsoleColor.Cyan;
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
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(24, 3);
            Console.WriteLine("Exercicio 1!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 5);
            double slm, sa, r;
            Console.Write("digite o sálario minimo: ");
            slm = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(4, 6);
            Console.Write("digite o seu sálario: ");
            sa = Convert.ToDouble(Console.ReadLine());        
            r = sa/slm;
            Console.SetCursorPosition(4, 7);
            Console.Write("Você recebe "+Math.Round(r, 2)+" sálarios minimos");
        }   
    }