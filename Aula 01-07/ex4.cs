//4 - Faça um programa para ler as 3 notas. Calcular a média de aproveitamento, usando a fórmula abaixo e 
// escrever o conceito do aluno de acordo com a tabela de conceitos mais abaixo:

using System;

class Program {
    static void Main(string[] args) {
        
        double n1, n2, n3, r;
        Console.Write("Digite a nota AP: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota TP: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a nota P: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        n1 = (n1*0.25);
        n2 = (n2*0.25);
        n3 = (n3*0.50);

        r = (n1+n2+n3);

        if(r >= 9){
        	Console.WriteLine(r);
        	Console.ForegroundColor = ConsoleColor.DarkBlue;
        	Console.WriteLine("Conceito A");
        }
        else if((r >= 7.5) && (r < 9)){
        	Console.WriteLine(r);
        	Console.ForegroundColor = ConsoleColor.Blue;
        	Console.WriteLine("Conceito B");
        }
        else if((r >= 6) && (r < 7.5)){
        	Console.WriteLine(r);
        	Console.ForegroundColor = ConsoleColor.Green;
        	Console.WriteLine("Conceito C");
        }
        else{
        	Console.WriteLine(r);
        	Console.ForegroundColor = ConsoleColor.DarkRed;
        	Console.WriteLine("Conceito D");
        }

    }
}