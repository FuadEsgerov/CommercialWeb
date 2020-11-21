using Repository.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Product:BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Brand { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public double SellingPrice { get; set; }
        [Required]
        public double BuyingPrice { get; set; }
        [Required]
        public StatusType Status { get; set; }
        public ICollection<ProductImage> Image { get; set; }
        public Category Category { get; set; }
        public SellMovement SellMovement { get; set; }

    }
}
