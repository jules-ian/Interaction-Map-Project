using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Dtos.Roles;
using Microsoft.AspNetCore.Identity;

namespace InteractiveMapProject.Contracts.Services;
public interface IRoleService
{
    Task<List<IdentityRole>> GetAllAsync();
    Task<IdentityRole> GetAsync(Guid id);
    Task CreateAsync(string roleName);
    Task DeleteAsync(Guid id);
}
