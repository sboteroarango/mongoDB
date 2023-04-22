﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Subsidios.Modelos
{
    public class Beneficiario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("ID")]
        public int? codigo { get; set; }
        [BsonElement("MUNICIPIO")]
        public string? municipio { get; set;}

        public Beneficiario()
        {
            Id = string.Empty;
            codigo = 0;
            municipio = string.Empty;
        }
    }
}
