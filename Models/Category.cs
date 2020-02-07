using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scouting_v2.Models
{
    public class Category
    {
        [Key]
        
        public int TeamId { get; set; }
        public string Team { get; set; }

        [NotMapped]
        public bool CheckBoxAnswer { get; set; }
    }
}