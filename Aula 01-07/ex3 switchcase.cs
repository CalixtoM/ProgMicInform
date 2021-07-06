

using System;

class Program {
    static void Main(string[] args) {
        int opcao;
        double sal, nsal, dif;
        Console.SetCursorPosition(4, 5);
        Console.Write("1 – Gerente. \n");
        Console.SetCursorPosition(4, 6);
        Console.Write("2 – Analista. \n");
        Console.SetCursorPosition(4, 7);
        Console.Write("3 – Técnico. \n");
        Console.Write("Informe seu sálario: ");
        sal = Convert.ToDouble(Console.ReadLine());
        Console.SetCursorPosition(4, 10);
        Console.Write("Escolha uma operação:");
        Console.SetCursorPosition(26, 10);
        opcao = Convert.ToInt32(Console.ReadLine());
        switch(opcao) {
            case 1:
                nsal = sal+(sal*0.10);
                dif = nsal-sal;
                Console.Write("sálario antigo: R$"+sal+", novo sálario: R$"+nsal+", diferença: R$"+dif);
            break;

            case 2:
                nsal = sal+(sal*0.20);
                dif = nsal-sal;
                Console.Write("sálario antigo: R$"+sal+", novo sálario: R$"+nsal+", diferença: R$"+dif);
            break;

            case 3:
                nsal = sal+(sal*0.30);
                dif = nsal-sal;
                Console.Write("sálario antigo: R$"+sal+", novo sálario: R$"+nsal+", diferença: R$"+dif);
            break;

            default:
                nsal = sal+(sal*0.40);
                dif = nsal-sal;
                Console.Write("sálario antigo: R$"+sal+", novo sálario: R$"+nsal+", diferença: R$"+dif);
            break;    
        }    
    }
}