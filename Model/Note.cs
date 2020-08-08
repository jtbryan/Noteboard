using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Noteboard.Model
{
    public class Note
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Details { get; set; }
    }
}