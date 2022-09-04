using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.Core.Entities.Concrete;
using YesilEv.Dal.Repositories.Abstract;

namespace YesilEv.Dal.Repositories.Concrete
{
    public class ProductRepository:GenericRepository<Product>,IProductRepository
    {
    }
}
