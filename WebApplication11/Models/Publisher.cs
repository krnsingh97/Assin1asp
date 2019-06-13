using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
       
        public string Name { get; set; }
       
        
        public string Website { get; set; }
    }
}