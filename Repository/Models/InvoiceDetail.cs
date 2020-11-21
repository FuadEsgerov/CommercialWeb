using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
  public  class InvoiceDetail:BaseEntity
    {
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [MaxLength(50)]
        public string QTY { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        [Required]
        public double Total { get; set; }
        public Invoice Invoice { get; set; }

    }
}
