using ApotheekApp.Business.Extensions;
using ApotheekApp.Domain.Models;
using ApotheekApp.Domain.Models.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApotheekApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthController(UserManager<AppUser> userManager, IConfiguration configuration, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _configuration = configuration;
            _roleManager = roleManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (model == null)
                return BadRequest();

            AppUser? existingUser = await _userManager.FindByEmailAsync(model.Email!);
            if (existingUser != null)
                return Conflict("User already exists");
            if (model.Email.IsValidEmail() &&
                model.Username.IsValidUsername() &&
                model.PhoneNumber.IsValidNlPhoneNumber())
            {
                var user = new AppUser
                {
                    Email = model.Email,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = model.Username,
                    PhoneNumber = model.PhoneNumber,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                };
                if (model.Password.IsValidPassword())
                {
                    IdentityResult? createUser = await _userManager.CreateAsync(user, model.Password!);
                    if (!createUser.Succeeded)
                    {
                        return StatusCode(StatusCodes.Status500InternalServerError, string.Join(';', createUser.Errors.Select(error => error.Description)));
                    }

                    return Ok(createUser);
                }
            }
            return BadRequest(model); //TODO: check if there is a cleaner way
        }

        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin(RegisterModel model)
        {
            if (model == null)
                return BadRequest();

            var existingUser = await _userManager.FindByEmailAsync(model.Username!);
            if (existingUser != null)
                return Conflict("User already exists");

            if (model.Email.IsValidEmail() &&
                model.Username.IsValidUsername() &&
                model.PhoneNumber.IsValidNlPhoneNumber())
            {
                var user = new AppUser()
                {
                    Email = model.Email,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = model.Username,
                    PhoneNumber = model.PhoneNumber,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                };
                if (model.Password.IsValidPassword())
                {
                    var createUser = await _userManager.CreateAsync(user, model.Password!);
                    if (!createUser.Succeeded)
                    {
                        return StatusCode(StatusCodes.Status500InternalServerError, string.Join(';', createUser.Errors.Select(error => error.Description)));
                    }

                    if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
                        await _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                    if (!await _roleManager.RoleExistsAsync(UserRoles.Employee))
                        await _roleManager.CreateAsync(new IdentityRole(UserRoles.Employee));

                    if (await _roleManager.RoleExistsAsync(UserRoles.Admin))
                    {
                        await _userManager.AddToRoleAsync(user, UserRoles.Admin);
                    }

                    return Ok(createUser);
                }
            }
            return BadRequest(model);//TODO: check if there's a cleaner way
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (model == null)
                return BadRequest();

            var user = await _userManager.FindByEmailAsync(model.Email!);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password!))
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName!)
                };
                claims.AddRange(userRoles.Select(role => new Claim(ClaimTypes.Role, role)));
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]!));

                var token = new JwtSecurityToken
                (
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(4),
                    claims: claims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256));

                return Ok(new
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }
    }
}