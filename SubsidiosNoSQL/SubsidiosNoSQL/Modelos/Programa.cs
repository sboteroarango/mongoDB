using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Subsidios.Modelos
{
    public class Programa
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ID")]
        public int? Codigo { get; set; }

        [BsonElement("NOMBRE")]
        public string? Nombre { get; set; }


        public Programa()
        {
            Id = string.Empty;
            Codigo = 0;
            Nombre = string.Empty;
        }
    }
}
