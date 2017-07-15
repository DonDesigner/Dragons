using Dragv2.Domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Dragv2.Domain.Repository
{
    public interface IDragaoRepository
    {
        void Add(Dragao dragao);
        IQueryable<Dragao> All<Dragao>();
        Dragao Single(Expression<Func<Dragao, bool>> expression);
        void Delete(Dragao dragao);
        void Update(Dragao dragao);
    }
}
