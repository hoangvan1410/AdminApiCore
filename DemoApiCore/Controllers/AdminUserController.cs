using API.Application.DTO;
using API.Core.Models;
using API.Infras.Services.UserAdmin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;


namespace DemoApiCore.Controllers
{
    public class AdminUserController : Controller
    {
        private readonly TestDbContext _context;
        private readonly IUserAdminServices _useradminServices;
        private readonly IConfiguration _configuration;
        public AdminUserController(IUserAdminServices useradminServices, IConfiguration configuration, TestDbContext context)
        {
            _useradminServices = useradminServices;
            _configuration = configuration;
            _context = context;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserAdminDTO request)
        {
            var user = await _context.UserAdmins.Where(x => x.Email == request.Email && x.IsDelete == false).SingleOrDefaultAsync();
            if(user == null) { return NotFound(); };
            if(user.Email != request.Email)
            {
                return BadRequest("User not found");
            }

            int salt = 11;
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password,salt);
            bool verified = BCrypt.Net.BCrypt.Verify(user.Password,passwordHash);
            if(verified)
            {
                string token = CreateToken(user);
                var data = new UserAdminResponse();
                da
            }
            
        }
    }
}
