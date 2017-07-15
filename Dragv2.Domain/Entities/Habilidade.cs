using Dragv2.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragv2.Domain.Entities
{
    public class Habilidade : Entidade
    {
        public Habilidade(string nome, Nivel nivel)
        {
            Nome = nome;
            Nivel = nivel;
        }

        public string Nome { get; private set; }
        public Nivel Nivel { get; private set; }
    }
}
