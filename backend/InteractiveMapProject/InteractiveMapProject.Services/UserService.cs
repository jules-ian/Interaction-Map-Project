using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Services;
using Microsoft.AspNetCore.Identity;
using NuGet.Common;

namespace InteractiveMapProject.Services;
public class UserService : IUserService
{
    private readonly UserManager<IdentityUser> _userManager;

    public UserService(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task CreateAsync(string email, string password)
    {
        var user = new IdentityUser
        {
            UserName = email,
            Email = email
        };
        var result = await _userManager.CreateAsync(user, password);
        if (!result.Succeeded)
        {
            throw new Exception(result.Errors.First().Description);
        }
    }

    public async Task<IdentityUser> GetAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);

        return user;
    }

    public async Task DeleteAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user != null)
        {
            await _userManager.DeleteAsync(user);
        }
    }

    public async Task UpdateEmailAsync(string oldEmail, string newEmail)
    {
        var user = await _userManager.FindByEmailAsync(oldEmail);
        if (user != null)
        {
            user.Email = newEmail;
            user.UserName = newEmail;
            await _userManager.UpdateAsync(user);
        }
    }

    public async Task UpdatePasswordAsync(string email, string newPassword)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user != null)
        {
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            await _userManager.ResetPasswordAsync(user, token, newPassword);
        }
    }


    public async Task AddToRoleAsync(string email, string roleName)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user != null)
        {
            await _userManager.AddToRoleAsync(user, roleName);
        }
    }

    public async Task RemoveFromRoleAsync(string email, string roleName)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user != null)
        {
            await _userManager.RemoveFromRoleAsync(user, roleName);
        }
    }

    public async Task<List<string>> GetRolesAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user != null)
        {
            var roles = await _userManager.GetRolesAsync(user);
            return roles.ToList();
        }
        return null;
    }

    public async Task<bool> IsInRoleAsync(string email, string roleName)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user != null)
        {
            return await _userManager.IsInRoleAsync(user, roleName);
        }
        return false;
    }

    public async Task<bool> CheckPasswordAsync(string email, string password)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user != null && await _userManager.CheckPasswordAsync(user, password))
        {
            return true;
        }
        return false;
    }

    public async Task ConfirmEmailAsync(string email, string token)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user != null)
        {
            await _userManager.ConfirmEmailAsync(user, token);
            /*
            if (result.Succeeded)
            {
                return Ok();
            }
            */
        }
    }

    public async Task<string> GenerateEmailConfirmationTokenAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        return token;
    }

    public async Task<string> GeneratePasswordResetTokenAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        return token;
    }

    public async Task ResetPasswordAsync(ResetPassword resetpwd)
    {
        var user = await _userManager.FindByEmailAsync(resetpwd.Email);
        await _userManager.ResetPasswordAsync(user,resetpwd.Token,resetpwd.Password);
    }
}
