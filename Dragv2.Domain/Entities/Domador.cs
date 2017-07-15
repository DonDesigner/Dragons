using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragv2.Domain.Entities
{
    public class Domador : Entidade
    {
        public Domador(string nome, int idade, Provincia provincia)
        {
            Nome = nome;
            Idade = idade;
            Provincia = provincia;
        }

        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public Provincia Provincia { get; private set; }

    }
}
