﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Developer
    {
        public int DeveloperId { get; set; }
        public string Name { get; set; }
        [Required]
        [Display(Name = "Developer Name required")]
        public string Website { get; set; }
    }
}