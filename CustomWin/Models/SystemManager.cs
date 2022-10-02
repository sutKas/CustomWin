using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWin.Models
{
    public class SystemManager
    {
        [Key]
        public int SyManagerId { get; set; }
        [Display(Name ="Profile")]
        public string Profile { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //relations

        public List<Lottery> Lotteries { get; set; }
         
    }
}
