using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.Core.Entities.Concrete;
using YesilEv.Dal.Repositories.Abstract;

namespace YesilEv.Dal.Repositories.Concrete
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public bool Login(string email, string password)
        {
             return _context.Users.Any(u=>u.Password==password);

        }
        
        
    }
}
