using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        [Required]
        [Display(Name = "Name required")]
        public string Description { get; set; }
    }
}