using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.Core.Entities.Abstract;

namespace YesilEv.Core.Entities.Concrete
{
    internal class User:IEntityBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        //
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public  DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public User CreatedBy { get; set; }
        public User ModifiedBy { get; set; }

        //NavigationProperty

        

    }
}
