using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using GWS.Domain.Admin;
namespace GWS.Hibernate.Mappings
{
    public class UserMap:ClassMap<User>
    {
        public UserMap()
        {
            LazyLoad();
            Table("userinfo");
            Id(x => x.UserId).Column("userid");
            Map(x => x.Name).Column("name");
        }
    }
}
