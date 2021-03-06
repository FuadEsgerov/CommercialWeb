﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class ProductImage
    {
        [Required]
        [MaxLength(150)]
        public string ImageUrl { get; set; }
        public Product Product { get; set; }
    }
}
