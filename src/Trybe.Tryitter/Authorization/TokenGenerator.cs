using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Trybe.Tryitter.Models;
using static Trybe.Tryitter.Authorization.Models.TokenConstants;

namespace Trybe.Tryitter.Authorization
{
    public class TokenGenerator
    {
        public string Generate(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(
                new SecurityTokenDescriptor()
                {
                    Subject = AddClaims(user),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Secret)),
                    SecurityAlgorithms.HmacSha256Signature),
                    Expires = DateTime.Now.AddDays(1)
                }
            );

            return tokenHandler.WriteToken(token);
        }

        private ClaimsIdentity AddClaims(User user)
        {
            var claims = new ClaimsIdentity();

            claims.AddClaim(new Claim("Name", user.Name));

            return claims;
        }
    }
}
