using System;

class Program {
    static void Main(string[] args) {
        
        int i, id, p;
        i = 1;
        p = 0;
        
        while(i<=10){
            Console.Write("Escreva uma idade: ");
            id = Convert.ToInt32(Console.ReadLine());

            if(id > 18){
                p++;
            }
            i++;
        }
        Console.Write(p+" pessoas com idade maior que 18");
    }
}