using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragv2.Domain.Entities
{
    public class Dragao : Entidade
    {
        private readonly IList<Habilidade> _habilidade;

        public Dragao(string nome, string familia, string cor, int idade, Domador domador)
        {
            Nome = nome;
            Familia = familia;
            Cor = cor;
            Idade = idade;
            Domador = domador;

            _habilidade = new List<Habilidade>();
        }

  
        public string Nome { get; private set; }
        public string Familia { get; private set; }
        public string Cor { get; private set; }
        public int Idade { get; private set; }
        public ICollection<Habilidade> Habilidade => _habilidade.ToArray();
        public Domador Domador { get; private set; }

        public bool IsLastetVersion(Dragao dragao)
        {
            var isEqual = true;

            if(Nome != dragao.Nome) { isEqual = false; };
            if(Familia != dragao.Familia) { isEqual = false; }
            if(Cor != dragao.Cor) { isEqual = false; };
            if(Idade != dragao.Idade) { isEqual = false; };

            return isEqual;
        }

        public void SetNome(string nome) => Nome = nome;
        public void SetFamilia(string familia) => Familia = familia;
        public void SetCor(string cor) => Cor = cor;

        public void AddHabilidade(Habilidade habil)
        {
            _habilidade.Add(habil);
        }

        public void AddDomador(Domador domador)
        {
            Domador = domador;
        }
    }
}
