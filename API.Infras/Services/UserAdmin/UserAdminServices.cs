using API.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Infras.Services.UserAdmin
{
    public class UserAdminServices : IUserAdminServices
    {
        private readonly TestDbContext _context;
        public UserAdminServices(TestDbContext context)
        {
            _context = context;
        }
    }
}
