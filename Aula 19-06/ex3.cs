using System;

class Program {
    static void Main(string[] args) {
        string nomecomp, nome, sobrenome, cont, sub;
        int esp;
        Console.Write("Digite seu nome completo: ");
        nomecomp = Console.ReadLine();
        esp = nomecomp.IndexOf(" ");
        esp = esp+1;
        nome = nomecomp.Substring(0, esp);
        sobrenome = nomecomp.Substring(esp);
        cont = nomecomp.Substring(6,5);
        sub = nomecomp.Replace("a", "o");
        Console.Write("Nome: " +nome +"\nsobrenome: "+sobrenome+"\n5 ao 10:"+cont+ "\ntrocar a por o: "+ sub);
    }
}