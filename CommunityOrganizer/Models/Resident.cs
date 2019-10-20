using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityOrganizer.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommunityOrganizer.Models
{
    public class Resident: IModel
    {
        public int Id { get; set; }
       
        [Display(Name ="First Name")]
        public string FirstName { get; set; }


       [Display(Name ="Last Name")]
        public string LastName { get; set; }


        [Display(Name ="Lot Number")]
        public int LotNumber { get; set; }

       
       [Display(Name ="Phone Number")]
        public int PhoneNumber { get; set; }


       
        public string Email { get; set; }
    }
}
