using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCampeonato
{
    class Jogador : Pessoa
    {
        public int codIncricao;
        public bool cadastroOK;
        int posicao;
        string alter;
        string delete;
        public int i = 0;
        public int cont = 0;

        //atributos partida

        public int quantPartida;
        public int quantV = 0;
        public int quantE = 0;
        public int quantD = 0;
        public int[] pts = new int[4];
        public string opCalculo = null;
        int escolha1 = 0;
        int escolha2 = 0;

        public Jogador[] jogador = new Jogador[4];

     
        public override void cadastrarDados()
        {
            if (i <= 3)
            {
                Console.Clear();
                Console.WriteLine("\n Digite o seu nome: \n");
                this.Nome = Console.ReadLine();

                while (this.Nome == "") // Enquato o nome estiver vazio, vai repetir a condi��o dentro do la�o
                {
                    if (this.Nome == "") // Se o nome estiver vazio, o usuario digita novamente
                    {
                        Console.WriteLine("      Erro! \n");
                        Console.WriteLine("\n Voc� n�o preencheu o seu nome! Digite novamente.\n");
                        this.Nome = Console.ReadLine();
                    }
                }

                Console.WriteLine("\n Digite o seu sobrenome: \n");
                this.Sobrenome = Console.ReadLine();

                while (this.Sobrenome == "") // Enquato o sobrenome estiver vazio, vai repetir a condi��o dentro do la�o
                {
                    if (this.Sobrenome == "") // Se o sobrenome estiver vazio, o usuario digita novamente
                    {
                        Console.WriteLine("      Erro! \n");
                        Console.WriteLine("\n Voc� n�o preencheu o seu sobrenome! Digite novamente.\n");
                        this.Sobrenome = Console.ReadLine();
                    }
                }

                Console.WriteLine("\n Digite o seu sexo (M ou F): \n");
                this.Sexo = Console.ReadLine().ToUpper();

                Console.WriteLine("\n Digite a sua identidade: \n");
                this.Identidade = double.Parse(Console.ReadLine());

                Console.WriteLine("\n Digite a sua idade: \n");
                this.Idade = int.Parse(Console.ReadLine());

                jogador[i] = new Jogador();
                jogador[i].Nome = Nome;
                jogador[i].Sobrenome = Sobrenome;
                jogador[i].Sexo = Sexo;
                jogador[i].Identidade = Identidade;
                jogador[i].Idade = Idade;
                jogador[i].codIncricao = codIncricao;
                i++;

                cadastroOK = true;
            }
            else
            {
                Console.WriteLine("\n Vagas lotadas para o campeonato, o m�ximo � quatro jogadores.");
                cadastroOK = false;
            }
        }

        public void consultarCodigo()
        {
            if (cadastroOK == true)
            {
                int posicao2;
                Console.WriteLine("\n Digite a sua posi��o: \n");
                posicao2 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n O seu c�digo de inscri��o �: {0}", jogador[posicao2].codIncricao);
            }
            else if (cadastroOK == false)
            {
                Console.WriteLine("\n Tente cadastrar-se novamente! ");
            }
            else
            {
                Console.WriteLine("\n Erro!");
            }
        }
        public override void mostrarDados()
        {
            if (i >= 1)
            {
                for (cont = 0; cont < i; cont++)
                {
                    posicao = cont + 1; //Guarda a posi��o do jogador
                    if (jogador[cont].Sexo == "M")
                    {
                        // Mostra dados do jogador
                        Console.WriteLine("\n " + posicao + "� Jogador: \n");
                        Console.WriteLine("Nome: {0} {1}", jogador[cont].Nome, jogador[cont].Sobrenome);
                        Console.WriteLine("Sexo: " + jogador[cont].Sexo);
                        Console.WriteLine("Identidade: " + jogador[cont].Identidade);
                        Console.WriteLine("Idade: " + jogador[cont].Idade);
                        Console.WriteLine("C�digo Inscri��o: " + jogador[cont].codIncricao);
                    }
                    else if (jogador[cont].Sexo == "F")
                    {
                        Console.WriteLine("\n " + posicao + "� Jogadora: \n");
                        Console.WriteLine("Nome: {0} {1}", jogador[cont].Nome, jogador[cont].Sobrenome);
                        Console.WriteLine("Sexo: " + jogador[cont].Sexo);
                        Console.WriteLine("Identidade: " + jogador[cont].Identidade);
                        Console.WriteLine("Idade: " + jogador[cont].Idade);
                        Console.WriteLine("C�digo Inscri��o: " + jogador[cont].codIncricao + "\n");

                    }
                    else
                    {
                        Console.WriteLine("\nErro! n�o foi possivel identificar o sexo.");

                    }
                }
            }
            else
            {
                Console.WriteLine("\n As vagas est�o vazias, cadastre um jogador!");
            }

        }

        public override void alterarDados()
        {
            if (i >= 1)
            {
                Console.Clear();
                Console.WriteLine("\n Deseja realmente alterar o jogador?\n");
                Console.WriteLine("\n  -  -  -  -  -  -  ");
                Console.WriteLine("\n |   (1) - SIM    |\n");
                Console.WriteLine("\n |   (2) - N�O    |\n");
                Console.WriteLine("  -  -  -  -  -  -  ");

                alter = Console.ReadLine();

                if (alter == "1")
                {
                    Console.WriteLine("\n Digite a posi��o do jogador que ser� alterada: \n");
                    posicao = int.Parse(Console.ReadLine());
                    jogador[posicao].cadastrarDados();

                }
                else if (alter == "2")
                {
                    Console.WriteLine("\n Usu�rio n�o alterado! \n");
                }
                else
                {
                    Console.WriteLine("\nErro! op��o incorreta.");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n As vagas est�o vazias, cadastre um jogador!");
            }
        }
        public override void deletarDados()
        {
            if (i >= 1)
            {
                Console.Clear();
                Console.WriteLine("\n Deseja realmente deletar o jogador?\n");
                Console.WriteLine("\n  -  -  -  -  -  -  ");
                Console.WriteLine("\n |   (1) - SIM    |\n");
                Console.WriteLine("\n |   (2) - N�O    |\n");
                Console.WriteLine("  -  -  -  -  -  -  ");
                delete = Console.ReadLine();

                if (delete == "1")
                {
                    Console.WriteLine("\n Digite a posi��o do jogador que ser� deletado: \n");
                    posicao = int.Parse(Console.ReadLine());

                    for (cont = posicao; cont < i - 1; cont++) 
                    {
                        jogador[cont] = jogador[cont + 1];
                    }
                    i--; //decremento
                }
                else if (delete == "2")
                {
                    Console.WriteLine("\n Usu�rio n�o deletado! \n");
                }
                else
                {
                    Console.WriteLine("\nErro! op��o incorreta.");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n As vagas est�o vazias, cadastre um jogador!");
            }
        }
        public void listarCompetidores()
        {
            if (i >= 1)
            {
                for (cont = 0; cont < i; cont++)
                {
                    Console.WriteLine("\n {0} - {1}", cont, jogador[cont].Nome);
                }
            }
            else
            {
                Console.WriteLine("\n As vagas est�o vazias, cadastre um jogador!");
            }
           
        }

        public void calcularPontos()
        {
            if (i >= 1)
            {
                Console.WriteLine("\n Digite a quantidade de partidas (M�ximo e recomend�vel 4 partidas) \n");
                quantPartida = int.Parse(Console.ReadLine());

                //Partida[] V = new Partida[quantPartida];

                Console.WriteLine("\n Digite as vit�rias de cada jogador. ");

                for (cont = 0; cont < quantPartida; cont++)
                {

                    Console.Clear();
                    Console.WriteLine("\n O jogador " + jogador[escolha1].Nome + " venceu a " + cont + "� partida contra " + jogador[escolha2].Nome + "?");
                    Console.WriteLine("\n  -  -  -  -  -  -  - ");
                    Console.WriteLine("\n |   (1) - VENCEU    |\n");
                    Console.WriteLine("\n |   (2) - PERDEU    |\n");
                    Console.WriteLine("\n |   (3) - EMPATE    |\n");
                    Console.WriteLine("  -  -  -  -  -  -  - ");

                    opCalculo = Console.ReadLine();

                    if (opCalculo == "1")
                    {
                        jogador[escolha1].quantV++;
                    }
                    else if (opCalculo == "2")
                    {
                        jogador[escolha1].quantD++;
                        jogador[escolha2].quantV++;
                    }
                    else if (opCalculo == "3")
                    {
                        jogador[escolha1].quantE++;
                        jogador[escolha2].quantE++;
                    }
                    else
                    {
                        Console.WriteLine("Erro! Op��o incorreta!");
                    }

                }
                for (cont = 0; cont < quantPartida; cont++)
                {
                    pts[cont] = jogador[cont].quantV * 3 + jogador[cont].quantE * 1 + jogador[cont].quantD * 0;
                }

                for (cont = 0; cont < 4; cont++)
                {
                    Console.WriteLine(jogador[cont].Nome + ": " + pts[cont] + " Pontos");
                }
            }
            else
            {
                Console.WriteLine("\n As vagas est�o vazias, cadastre um jogador!");
            }
        }

        public void selecionarJogador()
        {
            Console.WriteLine("\n Escolha o primeiro jogador: \n");
            escolha1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Escolha o segundo jogador: \n");
            escolha2 = int.Parse(Console.ReadLine());
            switch (escolha1)
            {
                case 0:
                    Console.WriteLine("\n 0 - Jogador " + jogador[0].Nome);
                    break;
                case 1:
                    Console.WriteLine("\n 1 - Jogador " + jogador[1].Nome);
                    break;
                case 2:
                    Console.WriteLine("\n 2 - Jogador " + jogador[2].Nome);
                    break;
                case 3:
                    Console.WriteLine("\n 3 - Jogador " + jogador[3].Nome);
                    break;
                default:
                    Console.WriteLine("\n O Jogador n�o existe");
                    break;
            }
            switch (escolha2)
            {
                case 0:
                    Console.WriteLine("\n 0 - Jogador " + jogador[0].Nome);
                    break;
                case 1:
                    Console.WriteLine("\n 1 - Jogador " + jogador[1].Nome);
                    break;
                case 2:
                    Console.WriteLine("\n 2 - Jogador " + jogador[2].Nome);
                    break;
                case 3:
                    Console.WriteLine("\n 3 - Jogador " + jogador[3].Nome);
                    break;
                default:
                    Console.WriteLine("\n O Jogador n�o existe");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n Jogador(a) " + jogador[escolha1].Nome + " VS Jogador(a) " + jogador[escolha2].Nome);
            Console.ReadKey();
        }

        public void mostraVencedor()
        {
            string option = null;
            Console.Clear();
            Console.WriteLine("\n Deseja saber qual pontuador venceu?\n");
            Console.WriteLine("\n  -  -  -  -  -  -  ");
            Console.WriteLine("\n |   (1) - SIM    |\n");
            Console.WriteLine("\n |   (2) - N�O    |\n");
            Console.WriteLine("  -  -  -  -  -  -  ");
            option = Console.ReadLine();


            if (option == "1")
            {
                int maior;
                maior = pts[0];
                for (int j = 1; j < 4; j++)
                {
                    if (maior < pts[j])
                    {
                        maior = pts[j];
                    }
                }
                Console.WriteLine("\n Venceu o jogador com " + maior + " Pontos!");
            }
            else if (option == "2")
            {
                Console.WriteLine("\n Ok! Voltando ao menu principal... \n");
            }
            else
            {
                Console.WriteLine("\nErro! op��o incorreta.");
            }
        }
    }
}

