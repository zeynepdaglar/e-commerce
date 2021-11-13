using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zeynep.Ecommerse.BusinessLogic.Authentication;
using Zeynep.Ecommerse.BusinessLogic.DAL;

namespace Zeynep.Ecommerse.BusinessLogic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        //Authentication ise kimlik doğrulamadır 
        private readonly ITokenManager _tokenManager;

        public AuthenticationController(ITokenManager tokenManager)
        {
            _tokenManager = tokenManager;
        }

        [HttpPost]
        public IActionResult Login(LoginParameter p)
        {
            var hash = DAL.User.GetPasswordHash(p.password); //gelen password hash e çevriliyor
            if (_tokenManager.Authenticate(p.username, hash)) //bilgiler doğru mu kontrol ediliyor
            {
                return Ok(new {
                    token = _tokenManager.NewToken(p.username)
                    });
            }
            
            return Unauthorized();
        }
    }

    public class LoginParameter
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
