using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityOrganizer.ViewModels.Administration
{
    public class AdministrationCreateViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
