using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class Category:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
