using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCampeonato
{
    class Competicao
    {
        public Jogador jog;

        public void menu()
        {
            Console.WriteLine("\n   -  -  -  -  -  -  -  -  -  - ");
            Console.WriteLine("\n |   (1) - CADASTRAR JOGADOR   |\n");
            Console.WriteLine("\n |   (2) - EXIBIR JOGADOR      |\n");
            Console.WriteLine("\n |   (3) - CONSULTAR C�DIGO    |\n");
            Console.WriteLine("\n |   (4) - ALTERAR JOGADOR     |\n");
            Console.WriteLine("\n |   (5) - DELETAR JOGADOR     |\n");
            Console.WriteLine("\n |   (6) - CAMPEONATO          |\n");
            Console.WriteLine("\n |   (Q) - SAIR DO PROGRAMA    |\n");
            Console.WriteLine("   -  -  -  -  -  -  -  -  -  -\n");
        }
    }
}
