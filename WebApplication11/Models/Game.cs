using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Game
    {
        public int GameId { get; set; }
        [Required]
        [Display(Name = "New Videogame")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Display(Name = "create a new videogame")]
        public int Price { get; set; }
        public string Minimum_Requirements { get; set; }
    }
}