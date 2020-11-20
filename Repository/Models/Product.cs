using Repository.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public double SellingPrice { get; set; }
        public double BuyingPrice { get; set; }
        public StatusType Status { get; set; }
        public ICollection<ProductImage> Image { get; set; }

    }
}
