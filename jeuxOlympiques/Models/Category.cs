﻿using System.ComponentModel.DataAnnotations;

namespace jeuxOlympiques.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
