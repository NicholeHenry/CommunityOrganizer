using System;
using System.Collections.Generic;
using System.Text;
using CommunityOrganizer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommunityOrganizer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Resident> Resident { get; set; }

        public DbSet<InformationBoard> InformationBoard { get; set; }

        public DbSet<AspNetRoles> AspNetRoles { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       
    }
}
