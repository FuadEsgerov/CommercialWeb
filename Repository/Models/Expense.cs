using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Expense:BaseEntity
    {
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public double Total { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }
}
