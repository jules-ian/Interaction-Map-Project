using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace InteractiveMapProject.Contracts.Services;
public interface IUserService
{
    Task CreateAsync(string email, string password);
    Task<IdentityUser> GetAsync(Guid id);
    Task<IdentityUser> GetAsync(string email);
    Task DeleteAsync(Guid id);
    Task DeleteAsync(string email);
    Task UpdateEmailAsync(Guid id, string newEmail);
    Task UpdateEmailAsync(string oldEmail, string newEmail);
    Task UpdatePasswordAsync(Guid id, string newPassword);
    Task UpdatePasswordAsync(string email, string newPassword);
    Task AddToRoleAsync(Guid id, string roleName);
    Task AddToRoleAsync(string email, string roleName);
    Task RemoveFromRoleAsync(Guid id, string roleName);
    Task RemoveFromRoleAsync(string email, string roleName);
    Task<List<string>> GetRolesAsync(Guid id);
    Task<List<string>> GetRolesAsync(string email);
    Task<bool> IsInRoleAsync(Guid id, string roleName);
    Task<bool> IsInRoleAsync(string email, string roleName);
    Task<bool> CheckPasswordAsync(Guid id, string password);
    Task<bool> CheckPasswordAsync(string email, string password);
}
