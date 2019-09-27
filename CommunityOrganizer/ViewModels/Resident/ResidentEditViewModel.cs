using CommunityOrganizer.Data.Repositories;
using CommunityOrganizer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityOrganizer.ViewModels
{
    public class ResidentEditViewModel
    {

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Lot Number")]
        public int LotNumber { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }


        public ResidentEditViewModel()
        {

        }
        public ResidentEditViewModel(int id)
        {

        }
        public ResidentEditViewModel(Factory repositoryFactory)
        {

        }

        public ResidentEditViewModel(int id, Factory repositoryFactory)
        {
            Resident resident = repositoryFactory.GetResidentRepository().GetById(id);
            this.FirstName = resident.FirstName;
            this.LastName = resident.LastName;
            this.LotNumber = resident.LotNumber;
            this.PhoneNumber = resident.PhoneNumber;
            this.Email = resident.Email;
        }
        public void Persist(int id, Factory repositoryFactory)
        {
            Models.Resident resident = new Models.Resident
            {

                FirstName = this.FirstName,
                LastName = this.LastName,
                LotNumber = this.LotNumber,
                PhoneNumber = this.PhoneNumber,
                Email = this.Email
            };
            repositoryFactory.GetResidentRepository().Update(resident);
        }
    }
}
