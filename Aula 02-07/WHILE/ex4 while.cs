using System;

class Program {
    static void Main(string[] args) {
        
        int i, j;
        i = 1;
        j = 1;
        while(i<=10){
            Console.Write("("+i+", ");
            while(j<=10){
                Console.Write( j+" ");
                j++;
            }
            Console.Write(")\n");
            j=1;
            i++;
        }
    }
}