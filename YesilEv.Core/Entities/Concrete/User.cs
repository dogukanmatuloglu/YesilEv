using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.Core.Entities.Abstract;

namespace YesilEv.Core.Entities.Concrete
{
    public class User:IEntityBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public  DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int? RoleId { get; set; }

        public int? BlackListProductContentId { get; set; }
        public int? FavoriteProductListId { get; set; }
        
        public Role Role { get; set; }
        public BlackListProductContent BlackListProductContent { get; set; }
        public FavoriteProductList FavoriteProductList { get; set; }
        public ICollection<SearchHistory> SearchHistories { get; set; }


    }
}
