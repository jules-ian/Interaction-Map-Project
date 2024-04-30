using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveMapProject.Contracts.Services;
public interface ITokenGeneratorService
{
    JwtSecurityToken GetToken(List<Claim> authClaims);
}
