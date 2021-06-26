using System;

class Program {
    static void Main(string[] args) {
    	double sm, sal, r;
        Console.WriteLine("Digite seu salario: ");
        sal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o salario minimo: ");
        sm = Convert.ToDouble(Console.ReadLine());
		r = (sal / sm);
        Console.WriteLine("Você recebe "+r+" salários minimos");
    }
}