using System;

class Program {
    static void Main(string[] args) {
    	double n1, r;
        Console.WriteLine("Digite um número: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        if(n1 < 20){
            Console.WriteLine("O número digitado é menor que 20");
        	r = n1*2;
        }
        else if(n1 > 20){
            Console.WriteLine("O número digitado é maior que 20");
        	r = n1/2;
        }
        else{
        	Console.WriteLine("O número digitado é igual a 20");
            r = 20;
        }
        Console.Write("O resultado foi: " +r);
    }
}