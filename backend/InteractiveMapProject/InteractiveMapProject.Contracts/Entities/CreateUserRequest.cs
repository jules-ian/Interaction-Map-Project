using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveMapProject.Contracts.Entities;
public class CreateUserRequest
{
    public string Email { get; set; }
    public string Password { get; set; }

    public CreateUserRequest(string email, string password)
    {
        Email = email;
        Password = password;
    }
}
