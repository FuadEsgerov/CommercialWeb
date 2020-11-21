using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public  class SellMovement:BaseEntity
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double TotalAmount { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Personal> Personals { get; set; }
        public ICollection<CurrentUser> CurrentUsers { get; set; }


    }
}
