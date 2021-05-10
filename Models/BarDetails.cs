using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BarsAPI.Models
{
    public class BarDetails
    {
        [Key]
        public int BarId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Website { get; set; }
        public string image { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Deposit { get; set; }
    }
}
