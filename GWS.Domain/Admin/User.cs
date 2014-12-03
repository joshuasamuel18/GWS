using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GWS.Domain.Admin
{
    public class User
    {
        public virtual int UserId { get; set; }
        public virtual string Name { get; set; }
    }
}
