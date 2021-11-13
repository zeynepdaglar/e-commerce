using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Zeynep.Ecommerse.BusinessLogic.Authentication
{
    public interface ITokenManager
    {
        bool Authenticate(string username, string password);

        string NewToken(string username);

        ClaimsPrincipal VerifyToken(string token);
    }
}
