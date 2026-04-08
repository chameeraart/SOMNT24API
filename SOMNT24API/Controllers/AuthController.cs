using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SOMNT24DAL.Data;
using SOMNT24DOMAIN.Common;
using SOMNT24DOMAIN.DTO;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SOMNT24API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbUserContext _context;
        public SessionManager SessionManager { get; }

        public AuthController(AppDbUserContext context, SessionManager sessionManager)
        {
            _context = context;
            SessionManager = sessionManager;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto loginDto)
        {
            var user = _context.ZYUser
                .FirstOrDefault(t => t.UserName == loginDto.Username);

            if (user == null)
            {
                return BadRequest("User name or Password Error");
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, "user")
            };

            var symmetricSecurityKey = new SymmetricSecurityKey(SessionManager.salt);
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                issuer: SessionManager.Issuer,
                audience: SessionManager.Audiance,
                expires: DateTime.Now.AddDays(15),
                signingCredentials: signingCredentials,
                claims: claims
            );

            return Ok(new UserDto()
            {
                JWT = new JwtSecurityTokenHandler().WriteToken(token),
                JwtValidFrom = token.ValidFrom,
                JwtValidTo = token.ValidTo,
                TokenType = "bearer",
                username = user.UserName,
            });
        }

        // ✅ OPTIONAL: GET USER LOGIN TEST
        [HttpPost("myUserLogin")]
        public IActionResult MyUserLogin([FromBody] LoginDto loginDto)
        {
            var userdetail = _context.ZYUser
                .FirstOrDefault(x => x.UserName == loginDto.Username);

            if (userdetail != null)
            {
                return Ok(userdetail.UserName);
            }

            return BadRequest(0);
        }
    }
}