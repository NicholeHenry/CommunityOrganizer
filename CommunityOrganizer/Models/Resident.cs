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
       
        [DisplayName("First Name")]
        public string FirstName { get; set; }


        [DisplayName("Last Name")]
        public string LastName { get; set; }


        [DisplayName("Lot Name")]
        public int LotNumber { get; set; }

        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }


        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}
