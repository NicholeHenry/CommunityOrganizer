using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityOrganizer.Data.Repositories;
using CommunityOrganizer.Models;
using CommunityOrganizer.ViewModels;
using CommunityOrganizer.ViewModels.AspNetRoles;
using Microsoft.AspNetCore.Mvc;

namespace CommunityOrganizer.Controllers
{
    public class AspNetRolesController : Controller
    {

        private Factory repositoryFactory;

        public AspNetRolesController(Factory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }
        public IActionResult Index()
        {

            List<AspNetRolesListViewModel> aspNetRoles = AspNetRolesListViewModel.GetAspNetRoles(repositoryFactory);
            return View(aspNetRoles);
        }

        [HttpGet]

        public IActionResult Create()
        {
            AspNetRolesCreateViewModel model = new AspNetRolesCreateViewModel(repositoryFactory);
            return View(model);
        }

        [HttpPost]

        public IActionResult Create(AspNetRolesCreateViewModel model)
        {
            model.Persist(repositoryFactory);
            return RedirectToAction(controllerName: nameof(AspNetRoles), actionName: nameof(Index));
        }

    }
}