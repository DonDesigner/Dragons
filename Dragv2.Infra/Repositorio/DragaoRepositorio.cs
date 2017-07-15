using Dragv2.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dragv2.Domain.Entities;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Dragv2.Infra.Repositorio
{
    public class DragaoRepositorio : IDragaoRepository
    {
        private IMongoDatabase _db;
        private IMongoClient _client;

        public DragaoRepositorio()
        {
            var casa = "mongodb://localhost:27017";
            var trab = "mongodb://sigameserver:27017";
            _client = new MongoClient(casa);


            //_client.Settings.GuidRepresentation = MongoDB.Bson.GuidRepresentation.Standard;

            _db = _client.GetDatabase("Dragon");
            //_db.Settings.GuidRepresentation = MongoDB.Bson.GuidRepresentation.Standard;
        }

        public void Add(Dragao dragao)
        {
            
            var col = _db.GetCollection<Dragao>("Dragoes");
            col.InsertOne(dragao);
        }

        public IQueryable<Dragao> All<Dragao>()
        {
            return _db.GetCollection<Dragao>("Dragoes").AsQueryable();
        }

        public Dragao Single(Expression<Func<Dragao, bool>> expression)
        {
            return _db.GetCollection<Dragao>("Dragoes").Find(expression).FirstOrDefault();
        }

        public void Delete(Dragao dragao)
        {
            var filtro = Builders<Dragao>.Filter.Where(x => x.Id == dragao.Id);
            _db.GetCollection<Dragao>("Dragoes").DeleteMany(filtro);            
        }

        public void Update(Dragao dragao)
        {

            var rep = _db.GetCollection<Dragao>("Dragoes").ReplaceOne(doc => doc.Id == dragao.Id, dragao);
            if (rep == null)
            {

            }


        }


    }
}
