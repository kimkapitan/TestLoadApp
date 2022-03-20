using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TestLoadApp.Api.Dal;
using TestLoadApp.Api.Models;

namespace TestLoadApp.Api.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly AppDbContext _appDbContext;
        public AuthController(AppDbContext appDbContext, SignInManager<IdentityUser> signInManager)
        {
            _appDbContext = appDbContext;
            _signInManager = signInManager;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginModelRequest model)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Email == model.Email);
            if (user == null) return Unauthorized();
            if ((await _signInManager.PasswordSignInAsync(user, model.Password, false, false)).Succeeded)
                return Ok(new LoginModelResponse
                {
                    AccessToken = GenerateJwtToken(user)
                });
            else return Unauthorized();
        }

        private string GenerateJwtToken(IdentityUser user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("VerySecretSecretVerySecretSecretVerySecretSecretVerySecretSecret");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { 
                    new Claim("id", user.Id.ToString()),
                    new Claim("username", user.UserName)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}
