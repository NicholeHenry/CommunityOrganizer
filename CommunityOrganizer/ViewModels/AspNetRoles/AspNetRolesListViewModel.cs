using CommunityOrganizer.Data.Repositories;
using CommunityOrganizer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityOrganizer.ViewModels.AspNetRoles
{
    public class AspNetRolesListViewModel
    {
        

        public static List<AspNetRolesListViewModel> GetAspNetRoles(Factory repositoryFactory)
        {
            return repositoryFactory.GetAspNetRolesRepository()
                .GetModels()
                .Select(a => new AspNetRolesListViewModel(a))
                .ToList();
        }
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        public string Name { get; set; }

        public AspNetRolesListViewModel(Models.AspNetRoles aspNetRoles)
        {
            this.Id = aspNetRoles.Id;
            this.Name = aspNetRoles.Name;
        }
    }
}
