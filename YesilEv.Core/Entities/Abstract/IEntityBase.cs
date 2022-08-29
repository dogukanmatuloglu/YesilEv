﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEv.Core.Entities.Concrete;

namespace YesilEv.Core.Entities.Abstract
{
    internal interface IEntityBase
    {
         int Id { get; set; }
         bool IsActive { get; set; }
         DateTime CreatedDate { get; set; }
         DateTime ModifiedDate { get; set; }
         User CreatedBy { get; set;}
         User ModifiedBy { get; set; }

    }
}
