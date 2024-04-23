using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using InteractiveMapProject.Contracts.Services;
using InteractiveMapProject.Contracts.UoW;
using AutoMapper;
using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using InteractiveMapProject.Contracts.Exceptions;
using InteractiveMapProject.Contracts.Services;
using InteractiveMapProject.Contracts.UoW;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Services;
public class RoleService : IRoleService
{
    private readonly RoleManager<IdentityRole> _roleManager;

    public RoleService(RoleManager<IdentityRole> roleManager)
    {
        _roleManager = roleManager;
    }

    public async Task CreateAsync(string roleName)
    {
        if (!await _roleManager.RoleExistsAsync(roleName))
        {
            await _roleManager.CreateAsync(new IdentityRole(roleName));
        }
    }

    async Task<List<IdentityRole>> IRoleService.GetAllAsync()
    {
        var roles = await _roleManager.Roles.ToListAsync();

        return roles;
    }

    async Task<IdentityRole> IRoleService.GetAsync(Guid id)
    {
        var role = await _roleManager.FindByIdAsync(id.ToString());

        return role;
    }

    async Task IRoleService.DeleteAsync(Guid id)
    {
        var role = await _roleManager.FindByIdAsync(id.ToString());
        if (role != null)
        {
            await _roleManager.DeleteAsync(role);
        }
    }

    async Task IRoleService.DeleteAsync(string roleName)
    {
        var role = await _roleManager.FindByNameAsync(roleName);
        if (role != null)
        {
            await _roleManager.DeleteAsync(role);
        }
    }
}
