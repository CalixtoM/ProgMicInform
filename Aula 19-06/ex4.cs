using System;

class Program {
    static void Main(string[] args) {
        string nome, nome1, sobrenome;
        int esp, esp1;
        Console.Write("Digite seu nome completo: ");
        nome = Console.ReadLine();
        esp = nome.IndexOf(" ");
        esp = esp+1;
        esp1 = esp-1;
        nome1 = nome.Substring(0, esp1);
        sobrenome = nome.Substring(esp);
        Console.Write("Seu email é: "+nome1+ "@fatec.sp.gov.br ou "+nome1+"."+sobrenome+"@fatec.sp.gov.br");    
      }
}