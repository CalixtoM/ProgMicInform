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
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("║                                              ║");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("║                                              ║");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("║                                              ║");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("║                                              ║");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("║                                              ║");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("║                                              ║");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 3);
            Console.WriteLine("Exercicio 5!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(4, 5);
            double n1, r;
        	Console.Write("Digite um número: ");
        	n1 = Convert.ToDouble(Console.ReadLine());
        
        	if(n1 < 20){
            	Console.SetCursorPosition(4, 6);
            	Console.WriteLine("O número digitado é menor que 20");
        		r = n1*2;
        	}
        	
        	else if(n1 > 20){
            	Console.SetCursorPosition(4, 6);
            	Console.WriteLine("O número digitado é maior que 20");
        		r = n1/2;
        	}
        	else{
            	Console.SetCursorPosition(4, 6);
        		Console.WriteLine("O número digitado é igual a 20");
            	r = 20;
        	}
        	
        	Console.SetCursorPosition(4, 7);
        	Console.Write("O resultado foi: " +r);
        }   
    }