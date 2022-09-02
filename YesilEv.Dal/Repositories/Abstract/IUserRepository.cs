using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.Core.Entities.Concrete;

namespace YesilEv.Dal.Repositories.Abstract
{
    internal interface IUserRepository:IGenericRepository<User>
    {
        bool Login(string email,string password);
        
    }
}
