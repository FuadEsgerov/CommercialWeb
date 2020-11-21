using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public  class Invoice:BaseEntity
    {
        [Required]
        public int No { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(50)]
        public string TaxeDepartment { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }

    }
}
