﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]//my third change
        public string Name { get; set; }

        public string Description { get; set; }//new change

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}