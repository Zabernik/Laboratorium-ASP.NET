using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ProducerEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Regon { get; set; }
        public string NIP { get; set; }
        public string ProducerCategory { get; set; }
        public ISet<ProductEntity> Products { get; set; }
    }
}
