using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragv2.Domain.Entities
{
    public abstract class Entidade
    {

        public Guid Id { get; private set; }

        protected Entidade()
        {
            Id = Guid.NewGuid();
        }
    }
}
