using System;

class Program {
    static void Main(string[] args) {
    	Console.BackgroundColor = ConsoleColor.Yellow;
    	Console.Clear();
        double tempc, tempk;
        Console.Write("Digite a temperatura em Celsius: ");
        tempc = Convert.ToDouble(Console.ReadLine());
        tempk = (tempc+273.15);
        Console.Write("Temperatura em Kelvin: "+tempk);
    }
}