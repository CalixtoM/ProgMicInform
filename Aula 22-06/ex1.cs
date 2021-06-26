using System;

class Program {
    static void Main(string[] args) {
    	double pq, pg, r;
        Console.WriteLine("Digite seu peso (em Kg): ");
        pq = Convert.ToDouble(Console.ReadLine());
		pg = (pq * 1000);
		pg = pg+(pg*0.10);
        Console.WriteLine("Seu peso em gramas com acréscimo de 10%: "+pg);
    }
}