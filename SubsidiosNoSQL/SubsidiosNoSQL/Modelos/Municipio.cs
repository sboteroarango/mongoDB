using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Subsidios.Modelos
{
    public class Municipio
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("ID")]
        public string? codigo { get; set; }

        [BsonElement("NOMBREMUNICIPIO")]
        public string? nombre { get; set; }

        [BsonElement("DEPARTAMENTO")]
        public string? departamento { get; set; }

        public Municipio()
        {
            Id = string.Empty;
            codigo = string.Empty;
            nombre = string.Empty;
            departamento = string.Empty;
        }
    }
}
