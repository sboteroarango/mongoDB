using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsidiosNoSQL
{
    public class SubsidiosDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string beneficiariosCollectionName { get; set; } = null!;
        public string departamentosCollectionName { get; set; } = null!;
        public string municipiosCollectionName { get; set; } = null!;
        public string programasCollectionName { get; set; } = null!;
        public string subsidiosCollectionName { get; set; } = null!;
    }
}
