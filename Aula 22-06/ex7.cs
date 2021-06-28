using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
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
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(24, 3);
            Console.WriteLine("Exercicio 7!");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(4, 5);
            double sal, prest, limite;
            Console.Write("digite o salario: ");
            sal = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(4, 6);   
            Console.Write("digite o valor da prestação: ");
            prest = Convert.ToDouble(Console.ReadLine());
            limite = (sal*0.30);
            
            if(prest <=limite){
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(4, 8);
                Console.Write("Prestação aprovada!");
            }
            else{
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(4, 8);
                Console.Write("Prestação reprovada!");
            }
        }   
    }