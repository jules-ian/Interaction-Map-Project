using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace InteractiveMapProject.Contracts.Entities;
public class ApplicationUser : IdentityUser
{
    public Guid? ProfessionalId { get; set; } // The professional associated with this user

}
