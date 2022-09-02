using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.Core.Entities.Abstract;

namespace YesilEv.Core.Entities.Concrete
{
    public class FavoriteProductList:IEntityBase//Favori Ürünlerin tablosu
    {

        

        //
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }


        //navigation property

        public ICollection<User> Users { get; set; }
        public ICollection<Product>  Products { get; set; }

    }
}
