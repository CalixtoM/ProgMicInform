using System;

class Program {
	static void Main(string[] args) {
		string nomecomp, nome1;
		int esp, esp1, ta;
		Console.Write("Digite seu nome completo: ");
		nomecomp = Console.ReadLine();
		esp = nomecomp.IndexOf(" ");
		esp = esp+1;
		char[] charsToTrim = {',', '.', ' '};
		string[] words = nomecomp.Split();
		foreach (string word in words)
		word.TrimEnd(charsToTrim);
		ta = words.Length;
		ta = ta-1;
		esp1 = esp-1;
		nome1 = nomecomp.Substring(0, esp1);
		Console.Write(nome1+"."+words [ta]+"@fatec.sp.gov.br ");
		Console.ReadKey();
       }
   }