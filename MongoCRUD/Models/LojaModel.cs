using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MongoCRUD.Models
{
    [DataContract]
    public class LojaModel
    {
        [DataMember]
        [BsonElement]
        [BsonRepresentation(BsonType.ObjectId )]
        public ObjectId Id;
        [DataMember]
        [BsonElement]
        [BsonRepresentation(BsonType.String)]
        public string Nome;
        [DataMember]
        [BsonElement]
        [BsonRepresentation(BsonType.String)]
        public string Cnpj;
        [DataMember]
        [BsonElement]
        [BsonRepresentation(BsonType.String)]
        public string Endereco;
        [DataMember]
        [BsonElement]
        [BsonRepresentation(BsonType.String)]
        public string Setor;
    }
}