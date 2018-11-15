using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokeDex.Models.Entities
{
    public class Pokemon
    {
        [Required]
        public string Code { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type1 { get; set; }
        [Required]
        public string Type2 { get; set; }
    }
}
