// MATHEUS OLIVEIRA matheus.oliveira161@fatec.sp.gov.br Verificar ano bixessexto Velocidade Média Área Polígono Regular 

using System;

class Program {
    static void Main(string[] args) {
    	int c = 0;
    	do{
    	Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.SetCursorPosition(2, 2);
        Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
        Console.SetCursorPosition(2, 3);
        Console.WriteLine("║                                                       ║");
        Console.SetCursorPosition(2, 4);
        Console.WriteLine("╠═══════════════════════════════════════════════════════╣");
        Console.SetCursorPosition(2, 5);
        Console.WriteLine("║                                                       ║");
        Console.SetCursorPosition(2, 6);
        Console.WriteLine("║                                                       ║");
        Console.SetCursorPosition(2, 7);
        Console.WriteLine("║                                                       ║");
        Console.SetCursorPosition(2, 8);
        Console.WriteLine("║                                                       ║");
        Console.SetCursorPosition(2, 9);
        Console.WriteLine("║     ╔═╗                                               ║");
        Console.SetCursorPosition(2, 10);
        Console.WriteLine("╠═════╣ ║                                               ║");
        Console.SetCursorPosition(2, 11);
        Console.WriteLine("║     ╚═╝                                               ║");
        Console.SetCursorPosition(2, 12);
        Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(19, 3);
        Console.Write("ESCOLHA UMA DAS OPÇÕES");
        Console.ForegroundColor = ConsoleColor.White;
        int opcao;
        Console.SetCursorPosition(4, 5);
        Console.Write("1 – Ano Bissexto. \n");
        Console.SetCursorPosition(4, 6);
        Console.Write("2 – Velociade média. \n");
        Console.SetCursorPosition(4, 7);
        Console.Write("3 – Área Poligono regular. \n");
        Console.SetCursorPosition(12, 14);
        Console.WriteLine("Prova! - Matheus Calixto De Oliveira");
        Console.SetCursorPosition(9, 10);
        opcao = Convert.ToInt32(Console.ReadLine());
        switch(opcao) {
            case 1:
        		Console.BackgroundColor = ConsoleColor.Black;
        		Console.Clear();
        		Console.ForegroundColor = ConsoleColor.DarkBlue;
        		Console.SetCursorPosition(2, 2);
        		Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
        		Console.SetCursorPosition(2, 3);
        		Console.WriteLine("║                                                       ║");
        		Console.SetCursorPosition(2, 4);
        		Console.WriteLine("╠═══════════════════════════════════════════════════════╣");
        		Console.SetCursorPosition(2, 5);
        		Console.WriteLine("║                                                       ║");
        		Console.SetCursorPosition(2, 6);
        		Console.WriteLine("║                                                       ║");
        		Console.SetCursorPosition(2, 7);
        		Console.WriteLine("║                                                       ║");
        		Console.SetCursorPosition(2, 8);
        		Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 9);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 10);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 11);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 12);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 13);
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(19, 3);
                Console.Write("ESCOLHA UMA DAS OPÇÕES");
                Console.SetCursorPosition(4, 5);
                Console.WriteLine("Ano Bissexto!");
                int ano;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(12, 14);
                Console.WriteLine("Prova! - Matheus Calixto De Oliveira");

                Console.SetCursorPosition(4, 7);
                Console.Write("Digite o ano: ");
                ano = Convert.ToInt32(Console.ReadLine());
                if(ano % 4 == 0){
                	Console.SetCursorPosition(4, 10);
					Console.Write("O ano digitado é bissexto!");                	
                }
                else{
                	Console.SetCursorPosition(4, 10);
                	Console.Write("O ano digitado não é bissexto!");                	
                }
            break;

            case 2:
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
        		Console.SetCursorPosition(2, 2);
        		Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
        		Console.SetCursorPosition(2, 3);
        		Console.WriteLine("║                                                       ║");
        		Console.SetCursorPosition(2, 4);
        		Console.WriteLine("╠═══════════════════════════════════════════════════════╣");
        		Console.SetCursorPosition(2, 5);
        		Console.WriteLine("║                                                       ║");
        		Console.SetCursorPosition(2, 6);
        		Console.WriteLine("║                                                       ║");
        		Console.SetCursorPosition(2, 7);
        		Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 8);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 9);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 10);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 11);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 12);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 13);
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(19, 3);
                Console.Write("ESCOLHA UMA DAS OPÇÕES");
                Console.SetCursorPosition(4, 5);
                Console.WriteLine("Velocidade média!");
                double vm, s, t;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(12, 14);
                Console.WriteLine("Prova! - Matheus Calixto De Oliveira");
                Console.SetCursorPosition(4, 7);
                Console.Write("Digite a distancia percorrida: ");
                s = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(4, 8);
                Console.Write("Digite o tempo para percorrer: ");
                t = Convert.ToDouble(Console.ReadLine());
                vm = (s/t);
                Console.SetCursorPosition(4, 10);
                Console.Write("A velocidade média é: "+vm);
            break;

            case 3:
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
        		Console.SetCursorPosition(2, 2);
        		Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
        		Console.SetCursorPosition(2, 3);
        		Console.WriteLine("║                                                       ║");
        		Console.SetCursorPosition(2, 4);
        		Console.WriteLine("╠═══════════════════════════════════════════════════════╣");
        		Console.SetCursorPosition(2, 5);
        		Console.WriteLine("║                                                       ║");
        		Console.SetCursorPosition(2, 6);
        		Console.WriteLine("║                                                       ║");
        		Console.SetCursorPosition(2, 7);
        		Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 8);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 9);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 10);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 11);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 12);
                Console.WriteLine("║                                                       ║");
                Console.SetCursorPosition(2, 13);
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(19, 3);
                Console.Write("ESCOLHA UMA DAS OPÇÕES");
                Console.SetCursorPosition(4, 5);
                Console.WriteLine("Área Polígono Regular!");
                double area, p, a;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(12, 14);
                Console.WriteLine("Prova! - Matheus Calixto De Oliveira");
                Console.SetCursorPosition(4, 7);
                Console.Write("Digite o perimetro do Poligono: ");
                p = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(4, 8);
                Console.Write("Digite apótema: ");
                a = Convert.ToDouble(Console.ReadLine());
                area = (p*a)/2;
                Console.SetCursorPosition(4, 10);
                Console.Write("A Área Polígono Regular é: "+area);

            break;

            default:
                Console.SetCursorPosition(4, 8);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Opção Inválida");
                break;
        }
        Console.SetCursorPosition(14, 11);
        Console.WriteLine("Digite '1' caso deseja recomeçar: ");
        Console.SetCursorPosition(4, 12);
        c = Convert.ToInt32(Console.ReadLine());
    	}while(c == 1);
    }
}