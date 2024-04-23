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
    Task<IdentityUser> GetAsync(string email);
    Task DeleteAsync(string email);
    Task UpdateEmailAsync(string oldEmail, string newEmail);
    Task UpdatePasswordAsync(string email, string newPassword);
    Task AddToRoleAsync(string email, string roleName);
    Task RemoveFromRoleAsync(string email, string roleName);
    Task<List<string>> GetRolesAsync(string email);
    Task<bool> IsInRoleAsync(string email, string roleName);
    Task<bool> CheckPasswordAsync(string email, string password);
}
