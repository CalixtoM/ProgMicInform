using System;

class Program {
    static void Main(string[] args) {
    	double n1;
        Console.WriteLine("Digite um número: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        if(n1 % 5 == 0){
            Console.WriteLine("O número digitado é multiplo de 5!");
        }
        else{
        	Console.WriteLine("O número digitado não é multiplo de 5!");
        }
    }
}