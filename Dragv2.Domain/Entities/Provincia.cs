using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragv2.Domain.Entities
{
    public class Provincia : Entidade
    {
        public Provincia(string nome, string regiao)
        {
            Nome = nome;
            Regiao = regiao;
        }

        public string Nome { get; private set; }
        public string Regiao { get; private set; }

    }


}
