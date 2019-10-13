using CommunityOrganizer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityOrganizer.ViewModels
{
    public class AspNetRolesCreateViewModel
    {
        public string Name { get; set; }

        public AspNetRolesCreateViewModel()
        {

        }

        public AspNetRolesCreateViewModel(Factory repositoryFactory)
        {

        }

        public void Persist(Factory repositoryFactory)
        {
            Models.AspNetRoles aspNetRoles = new Models.AspNetRoles
            {
                Name = this.Name
            };
            repositoryFactory.GetAspNetRolesRepository().Save(aspNetRoles);
        }
    }
}
