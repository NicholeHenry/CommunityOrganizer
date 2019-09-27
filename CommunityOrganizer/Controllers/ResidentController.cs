using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityOrganizer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CommunityOrganizer.Controllers
{
    public class ResidentController : Controller
    {

        private TaskFactory repositoryFactory;

        public ResidentController(TaskFactory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }
        public IActionResult Index()
        {
            List<ResidentListViewModel> residents = ResidentListViewModel.GetResident(repositoryFactory);
            return View(residents);
        }
    }
}