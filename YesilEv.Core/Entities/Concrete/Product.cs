using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.Core.Entities.Abstract;

namespace YesilEv.Core.Entities.Concrete
{
    public class Product : IEntityBase
    {
        public string Name  { get; set; }
        public Guid Barcode { get; set; }
        
        public string FrontImage { get; set; }
        public string BackImage { get; set; }
        public bool IsApproved { get; set; }



        //
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }

        //NavigationProperty
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<Content> Contents { get; set; }

        public ICollection<FavoriteProductList> FavoriteProductLists { get; set; }
    }
}
