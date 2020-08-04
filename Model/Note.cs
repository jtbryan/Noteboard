using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Noteboard.Model
{
    public class Note
    {
        // data annotation
        // this will automatically add id as an identity column
        [Key]
        public int Id {get; set;}

        // data annotation
        // This means title cannot be NULL
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}