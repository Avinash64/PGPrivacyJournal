using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PrivacyJournal.API.Models;

namespace PrivacyJournal.API.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public ActionResult<object> GetLogin(Login login)
        {

        var issuer= "eeee";
        var audience= "bruh";
        var key= "samplekeeeeeeeeeeeeeeey";

            var account = ProfileStore.Current.Profiles.FirstOrDefault(c => c.Username == login.Username);
            if (account == null){
                return Unauthorized(new {success = false, bruh="bruh"});
            }
            if (account.Password == login.Password){
                var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim("Id", Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, login.Username),
                new Claim(JwtRegisteredClaimNames.Jti,
                Guid.NewGuid().ToString())
             }),
            Expires = DateTime.UtcNow.AddMinutes(5),
            Issuer = issuer,
            Audience = audience,
            SigningCredentials = new SigningCredentials
            (new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
            SecurityAlgorithms.HmacSha512Signature)
        };
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var jwtToken = tokenHandler.WriteToken(token);
        var stringToken = tokenHandler.WriteToken(token);
                return Ok( new {success = true, token = stringToken});
            }
            return Unauthorized(new {success = false});;
        }
    }
}