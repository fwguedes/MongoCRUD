using MongoDB.Bson;
using MongoDB.Driver;
using MongoCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;

namespace MongoCRUD.DAO {
    public class LojaDAO {

        protected static IMongoClient cliente;
        protected static IMongoDatabase banco;

        public LojaDAO() {
            cliente = new MongoClient();
            banco = cliente.GetDatabase("local");

        }

        public async void Adicionar(LojaModel novaLoja) {
            var colecao = banco.GetCollection<BsonDocument>("Lojas");
            await colecao.InsertOneAsync(novaLoja.ToBsonDocument());

        }


        public async void Listar() {
            var colecao = banco.GetCollection<BsonDocument>("Lojas");
            var filter = new BsonDocument();

            using (var cursor = await colecao.FindAsync(filter)) {
                while (await cursor.MoveNextAsync()) {
                    var batch = cursor.Current;

                    foreach (var document in batch) {
                        

                        //Adicionar uma projecao de campos para nao pegar o _id
                        LojaModel loja = BsonSerializer.Deserialize<LojaModel>(document);

                    }
                }
            }
        }
    }
}