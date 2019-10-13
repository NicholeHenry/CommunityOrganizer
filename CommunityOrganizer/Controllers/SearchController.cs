using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityOrganizer.Data;
using Microsoft.AspNetCore.Mvc;
using CommunityOrganizer.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityOrganizer.Controllers
{
    public class SearchController : Controller
    {

        private ApplicationDbContext context;

        public SearchController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Search(string searchString)
        {
            var residents = from r in context.Resident
                            select r;
            if (!String.IsNullOrEmpty(searchString))
            {
                residents = residents.Where(s => s.LastName.Contains(searchString) || s.FirstName.Contains(searchString));
            }

            return View(await residents.ToListAsync());
        }
       
    }
}