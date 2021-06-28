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
            Console.ForegroundColor = ConsoleColor.Blue;
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
            Console.WriteLine("Exercicio 4!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 5);
            double pq, pg, r;
            Console.Write("Digite seu peso (em Kg): ");
            pq = Convert.ToDouble(Console.ReadLine());
		    pg = (pq * 1000);
		    r = pg+(pg*0.10);
            Console.SetCursorPosition(4, 7);
		    Console.WriteLine("Seu peso em gramas: "+pg);
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("Seu peso em gramas com acréscimo de 10%: "+r);
        }   
    }