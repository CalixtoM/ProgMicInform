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
            Console.ForegroundColor = ConsoleColor.Magenta;
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
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(24, 3);
            Console.WriteLine("Exercicio 8!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 5);
            double n1;
            Console.Write("Digite um número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            if(n1 > 0){
              Console.SetCursorPosition(4, 8);
               Console.WriteLine("O número digitado é positivo");
            }
            else if(n1<0){
              Console.SetCursorPosition(4, 8);
               Console.WriteLine("O número digitado é negativo");
            }
            else{
              Console.SetCursorPosition(4, 8);
               Console.WriteLine("O número digitado é igual a zero");   
            }
        }   
    }