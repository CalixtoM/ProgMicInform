using System;

class Program {
    static void Main(string[] args) {
        double a, d, p, r, r2, p1;
        Console.Write("Digite o valor do raio: ");
    	r = Convert.ToDouble(Console.ReadLine());
      	p1 = Math.PI;
    	r2 = Math.Pow(r, 2);
    	a = p1*r2;
    	d = 2*r;
    	p = 2*p1*r;
    	Console.Write("Area: "+a+ " Diametro: "+d+ " Perimetro: " +p);
        Console.ReadKey();
    }
}