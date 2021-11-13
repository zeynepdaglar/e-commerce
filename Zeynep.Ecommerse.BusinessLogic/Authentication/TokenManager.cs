using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Zeynep.Ecommerse.BusinessLogic.DAL;

namespace Zeynep.Ecommerse.BusinessLogic.Authentication
{
    public class TokenManager : ITokenManager
    {
        private readonly DatabaseContext _db;
        private JwtSecurityTokenHandler _jwtSecurityTokenHandler;
        private byte[] _secretKey; 



        public TokenManager(DatabaseContext databaseContext)
        {
            _jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            _secretKey = Encoding.ASCII.GetBytes("012345678901234567890123456789ab");
            _db = databaseContext;
        }

        public bool Authenticate(string username, string password)
        {

            var user = _db.Users
                .Where(x => x.Username == username && x.Password == password) //bizeki verilerle gelen bilgiler eşleşiyor mu
                .FirstOrDefault();

            return user != null;
        }

        public string NewToken(string username)
        {
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.Name, username)}),
                Expires = DateTime.UtcNow.AddDays(365), //geçerlilik süresi
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(_secretKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = _jwtSecurityTokenHandler.CreateToken(tokenDescriptor);
            var jwtString = _jwtSecurityTokenHandler.WriteToken(token);

            return jwtString;
        }

        public ClaimsPrincipal VerifyToken(string token)
        {
            var claims = _jwtSecurityTokenHandler.ValidateToken(
                token,
                new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(_secretKey),
                    ValidateLifetime = true,
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

            return claims;
        }
    }
}
