//3 - Faça um programa para ler: a descrição do produto (nome), a quantidade adquirida e o preço unitário.
//Calcular e escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total a pagar
// (total a pagar = total - desconto), sabendo-se que:

// - Se quantidade <= 5 o desconto será de 2%

// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%

// - Se quantidade > 10 o desconto será de 5%

using System;

class Program {
    static void Main(string[] args) {
        
        int qnt;
        double preco, t, td, d;
        Console.Write("Escreva o nome do produto: ");
    	string nome = Console.ReadLine();
    	Console.Write("Digite a quantidade: ");
    	qnt = Convert.ToInt32(Console.ReadLine());
    	Console.Write("Escreva o valor do produto: ");
    	preco = Convert.ToDouble(Console.ReadLine());
    	t = preco*qnt;

    	if(qnt <= 5){
    		d = t * 0.02;
    		td = t-d;
    	}
    	else if(qnt > 5 && qnt <= 10){
    		d = t * 0.03;
    		td = t-d;
    	}
    	else{
    		d = t * 0.05;
    		td = t-d;
    	}
    	Console.Write("Produto: " +nome);
    	Console.Write(" Total sem desconto: "+t+", Desconto: "+d+", Total com desconto: "+td);
    }
}