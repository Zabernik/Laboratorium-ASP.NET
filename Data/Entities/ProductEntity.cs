using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("products")]
    public class ProductEntity
    {
        [Column("product_id")]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime? DateOdProduction { get; set; }
        public string Description { get; set; }
    }
}
