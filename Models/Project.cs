﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookStoreProject.Models
{
    public class Project
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression("^[0 - 9][0 - 9][0 - 9][-][0 - 9][0 - 9][0 - 9][0 - 9][0 - 9][0 - 9][0 - 9][0 - 9][0 - 9][0 - 9]$")]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public float Price { get; set; }
    }
}