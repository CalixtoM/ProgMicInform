using System;

class Program {
    static void Main(string[] args) {
    	double n1;
        Console.WriteLine("Digite um número: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        if(n1 > 0){
            Console.WriteLine("O número digitado é positivo");
        }
        else if(n1<0){
        	Console.WriteLine("O número digitado é negativo");
        }
        else{
            Console.WriteLine("O número digitado é igual a zero");   
        }
    }
}