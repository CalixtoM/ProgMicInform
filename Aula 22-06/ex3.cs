using System;

class Program {
    static void Main(string[] args) {
    	double tempk, tempc;
        Console.WriteLine("Digite a temperatura em fahrenheit: ");
        tempk = Convert.ToDouble(Console.ReadLine());
        tempc = (tempk - 32)*(0.555555556);
        Console.WriteLine("A temperatura em Celsius é: "+Math.Round(tempc));       
    }
}