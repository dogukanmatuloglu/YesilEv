using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.Core.Entities.Abstract;

namespace YesilEv.Core.Entities.Concrete
{
    public class Claim:IEntityBase
    {
        public string Name { get; set; }

        //IEntityBaseden gelen propertyler
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }

        // navigation Property
        //claim-role arasında çokaçok ilişki vardır.
        public ICollection<Role> Roles { get; set; }


    }
}
