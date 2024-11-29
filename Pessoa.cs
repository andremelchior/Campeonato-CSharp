using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCampeonato
{
    public abstract class Pessoa
    {
        protected string Nome { get; set; }
        protected string Sobrenome { get; set; }
        protected string Sexo { get; set; }
        protected double Identidade { get; set; }
        protected int Idade { get; set; }

        public abstract void cadastrarDados();
        public abstract void mostrarDados();
        public abstract void alterarDados();
        public abstract void deletarDados();

    }
}
