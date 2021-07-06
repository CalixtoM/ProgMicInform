// 1 – Elabore um programa que crie o seguinte menu: Formulas: 1 – Baskara. 2 – Força. (F = m * a) 
// 3 – Velocidade. (V = Vo + a*t)

using System;

class Program {
    static void Main(string[] args) {
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
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(24, 3);
        Console.WriteLine("Exercicio 1!");
        Console.ForegroundColor = ConsoleColor.White;
        int menu;
        Console.SetCursorPosition(4, 5);
        Console.Write("1 – Baskara. \n");
        Console.SetCursorPosition(4, 6);
        Console.Write("2 – Força. \n");
        Console.SetCursorPosition(4, 7);
        Console.Write("3 – Velocidade. \n");
        Console.SetCursorPosition(51, 6);        
        Console.WriteLine("( )");
        Console.SetCursorPosition(52, 6);
        menu = Convert.ToInt32(Console.ReadLine());
        switch(menu) {
            case 1:
                Console.Clear();
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
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(24, 3);
                Console.WriteLine("Exercicio 1!");
                Console.ForegroundColor = ConsoleColor.White;
                double a, b, b2, c, delta, delta2, x1, x2;
                Console.SetCursorPosition(4, 5);
                Console.Write("Digite o valor de a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(4, 6);
                Console.Write("Digite o valor de b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(4, 7);
                Console.Write("Digite o valor de c: ");
                c = Convert.ToDouble(Console.ReadLine());
                b2 = Math.Pow(b, 2);
                delta = b2-4*a*c;
                delta2 = Math.Sqrt(delta);
                x1 = (((b*(-1))+delta2)/(2*a));
                x2 = (((b*(-1))-delta2)/(2*a));
                Console.SetCursorPosition(16, 8);
                Console.Write("Delta: "+delta+ ", x1: "+x1+ ", x2: " +x2);
                Console.ReadKey();
                break;

            case 2:
                Console.Clear();
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
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(24, 3);
                Console.WriteLine("Exercicio 1! - SwitchCase");
                Console.ForegroundColor = ConsoleColor.White;
                double f, m, ace;
                Console.SetCursorPosition(4, 5);
                Console.Write("Informe o valor da massa: ");
                m = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(4, 6);
                Console.Write("Informe o valor da aceleração: ");
                ace = Convert.ToDouble(Console.ReadLine());
                f = m*ace;
                Console.SetCursorPosition(24, 8);
                Console.Write("Força: "+f);
                break;

            case 3:
                Console.Clear();
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
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(24, 3);
                Console.WriteLine("Exercicio 1!");
                Console.ForegroundColor = ConsoleColor.White;
                double v, vo, ac, t;
                Console.SetCursorPosition(4, 5);
                Console.Write("Informe o valor de Velocidade inicial: ");
                vo = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(4, 6);
                Console.Write("Informe o valor de aceleração: ");
                ac = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(4, 7);
                Console.Write("Informe o valor de tempo: ");
                t = Convert.ToDouble(Console.ReadLine());
                v = vo+(ac*t);
                Console.SetCursorPosition(21, 8);
                Console.Write("Velocidade: "+v);
                break;

            default:
                Console.SetCursorPosition(4, 8);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Opção Inválida");
                break;
        }



    }
}