using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoit.Models
{
    public class Formation
    {
        [Key]
        public int FormID { get; set; }
        [Display(Name = "Titre")]
        public string title { get; set; }
        [Display(Name = "Descritption")]
        public string description { get; set; }
        [Display(Name = "Média")]
        public string media { get; set; }
    }
}
