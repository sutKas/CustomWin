using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWin.Models
{
    public class Player
    {
     
        [Key]

        public int PlayerId { get; set; }
        [Display(Name = "Profile")]
        public string Profile { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="This field is required")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }

        

        //relations
        public List<PurchasedLottery> PurchasedLotteries { get; set; }


    }

}
