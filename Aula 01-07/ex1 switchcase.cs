// 1 – Elabore um programa que crie o seguinte menu: Formulas: 1 – Baskara. 2 – Força. (F = m * a) 
// 3 – Velocidade. (V = Vo + a*t)

using System;

class Program {
    static void Main(string[] args) {
        
        int menu;
        Console.Write("1 – Baskara. \n");
        Console.Write("2 – Força. \n");
        Console.Write("3 – Velocidade. \n");
        menu = Convert.ToInt32(Console.ReadLine());
        switch(menu) {
            case 1:
                double a, b, b2, c, delta, delta2, x1, x2;
                Console.Write("Digite o valor de a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o valor de b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o valor de c: ");
                c = Convert.ToDouble(Console.ReadLine());
                b2 = Math.Pow(b, 2);
                delta = b2-4*a*c;
                delta2 = Math.Sqrt(delta);
                x1 = (((b*(-1))+delta2)/(2*a));
                x2 = (((b*(-1))-delta2)/(2*a));
                Console.Write("Delta: "+delta+ ", x1: "+x1+ ", x2: " +x2);
                Console.ReadKey();
                break;    
            case 2:
                double f, m, ace;
                Console.Write("Informe o valor da massa: ");
                m = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o valor da aceleração: ");
                ace = Convert.ToDouble(Console.ReadLine());
                f = m*ace;
                Console.Write("Força: "+f);
                break;
            case 3:
                double v, vo, ac, t;
                Console.Write("Informe o valor de Velocidade inicial: ");
                vo = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o valor de aceleração: ");
                ac = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o valor de tempo: ");
                t = Convert.ToDouble(Console.ReadLine());
                v = vo+(ac*t);
                Console.Write("Velocidade: "+v);
                break;        
        }



    }
}