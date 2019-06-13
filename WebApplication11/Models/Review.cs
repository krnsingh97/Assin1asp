using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Number_of_stars { get; set; }
        [Required]
        [Range(1, 5)]
        
        public string Reviews { get; set; }
       
      
       
    }
}