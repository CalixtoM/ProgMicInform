//3 - Faça um programa para ler: a descrição do produto (nome), a quantidade adquirida e o preço unitário.
//Calcular e escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total a pagar
// (total a pagar = total - desconto), sabendo-se que:

// - Se quantidade <= 5 o desconto será de 2%

// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%

// - Se quantidade > 10 o desconto será de 5%

using System;

class Program {
    static void Main(string[] args) {
        
        int opcao;
        double n1, n2, r;
        Console.SetCursorPosition(4, 5);
        Console.Write("1 – Adição. \n");
        Console.SetCursorPosition(4, 6);
        Console.Write("2 – Subtração. \n");
        Console.SetCursorPosition(4, 7);
        Console.Write("3 – Multiplicação. \n");
        Console.SetCursorPosition(4, 8);
        Console.Write("4 – Divisão. \n");
        Console.Write("Escolha uma operação: ");
        opcao = Convert.ToInt32(Console.ReadLine());
        switch(opcao) {
            case 1:
                Console.Write("Digite o primeiro numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                r = n1+n2;
                Console.Write(r);

            break;
        }
    }
}