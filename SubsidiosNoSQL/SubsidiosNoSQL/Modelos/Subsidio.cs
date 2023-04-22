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
    public class Subsidio
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("PROGRAMA")]
        public int? programa { get; set; }

        [BsonElement("BENEFICIARIO")]
        public long beneficiario { get; set; }

        [BsonElement("MES")]
        public int mes { get; set; }

        [BsonElement("AÑO")]
        public int año { get; set; }

        [BsonElement("VALOR ASIGNADO")]
        public int valorAsignado { get; set; }

        [BsonElement("ID")]
        public int? codigo { get; set; }

        public Subsidio()
        {
            Id = string.Empty;
            codigo = 0;
            programa = 0;
            beneficiario = 0;
            mes = 0;
            año = 0;
            valorAsignado = 0;
           
        }
    }
}