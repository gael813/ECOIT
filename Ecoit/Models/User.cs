using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoit.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string login { get; set; }
        /// <summary></summary>
        public int statut { get; set; }
        /// <summary></summary>
        public List<Formation> lstFormation {get;set;}
    }
}
