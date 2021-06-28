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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.WriteLine("Exercicio 6!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(5, 5);
            double n1;
            Console.Write("Digite um número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            if(n1 % 5 == 0){
                Console.SetCursorPosition(5, 8);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O número digitado é multiplo de 5!");
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(5, 8);
                Console.WriteLine("O número digitado não é multiplo de 5!");
            } 
        }
    }

