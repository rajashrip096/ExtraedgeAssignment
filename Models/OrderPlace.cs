using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Models
{
    [Table("OrderPlace")]
    public class OrderPlace
    {
        [Key]
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string Email { get; set; }
        public  string Address{ get; set; }
        public int Price { get; set; }
    }
}
