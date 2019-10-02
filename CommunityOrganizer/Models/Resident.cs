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
       
        
        public string FirstName { get; set; }


       
        public string LastName { get; set; }


        
        public int LotNumber { get; set; }

       
       
        public int PhoneNumber { get; set; }


       
        public string Email { get; set; }
    }
}
