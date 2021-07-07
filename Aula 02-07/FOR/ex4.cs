using System;

class Program {
    static void Main(string[] args) {
        
        int i;
        double ma, me, n;
        ma=0;
        me=0;

        for(i = 1; i<=20; i++ ){
            Console.Write("Digite um número: ");
            n = Convert.ToDouble(Console.ReadLine());
            if(i == 1){
                ma = n;
                me = n;
            }
            else{
                if(n < me){
                    me = n;
                }
                else if(n > ma){
                    ma = n;
                }
            }
        }
        Console.Write("Maior Número: "+ma+"\n");
        Console.Write("Menor Número: "+me);
    }
}