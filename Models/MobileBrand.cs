using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Models
{
    [Table("MobileBrand")]
    public class MobileBrand
    {
        [Key]
        public int Id { get; set; }
        public string BrandName { get; set; }
        public int ModelNo { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public string FromToDate { get; set; }
    }
}
