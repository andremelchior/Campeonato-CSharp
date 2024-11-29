using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCampeonato
{
    class Program
    {
        static void Main(string[] args)
        {
            Competicao C = new Competicao();
            C.jog = new Jogador();


            Jogador J = new Jogador();

            string op = null;

            Console.WriteLine("\n Programa: Campeonato individual");



            do
            {
                Console.WriteLine("\n Digite uma op��o: \n");
                C.menu();
                op = Console.ReadLine();
                switch (op.ToUpper())
                {
                    case "1":
                        Console.Clear();
                        J.cadastrarDados();
                        Random numAleatorio = new Random();
                        J.codIncricao = numAleatorio.Next(1, 20);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        J.mostrarDados();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        J.consultarCodigo();
                        Console.ReadKey();
                        break;
                    case "4":
                        J.alterarDados();
                        Console.ReadKey();
                        break;
                    case "5":
                        J.deletarDados();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        if (J.i >= 1)
                        {
                            J.listarCompetidores();
                            Console.WriteLine("\n Escolha dois jogadores para disputar");
                            J.selecionarJogador();
                            J.calcularPontos();
                            Console.ReadKey();
                            J.mostraVencedor();
                        }
                        else
                        {
                            Console.WriteLine("\n As vagas est�o vazias, cadastre um jogador!");
                        }
                        Console.ReadKey();
                        break;
                    case "Q":
                        Console.Clear();
                        Console.Write("\n\n\n\n\n          - - - - - - - - - - - - - - - - ");
                        Console.Write("\n\t |                               |");
                        Console.Write("\n\n\t |                               |");
                        Console.Write("\n\n\t |     Saindo do programa...     |");
                        Console.Write("\n\n\t |                               |");
                        Console.Write("\n\n\t |                               |");
                        Console.WriteLine("\n          - - - - - - - - - - - - - - - - \n");
                        break;
                    default:
                        Console.WriteLine("\nErro! op��o incorreta.");
                        Console.ReadKey();
                        break;
                }    
                
            } while(op.ToUpper() != "Q");


            Console.ReadKey();
        }
    }
}
