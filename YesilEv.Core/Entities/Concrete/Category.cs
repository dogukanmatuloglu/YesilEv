using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.Core.Entities.Abstract;

namespace YesilEv.Core.Entities.Concrete
{
    public class Category : IEntityBase
    {
        public string Name { get; set; }
        public int? TopCategoryId { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        //NavigationProperty

        public ICollection<Product> Products { get; set; }
        public ICollection<Category> Categories { get; set; }
        public Category TopCategory { get; set; }
    }
}
