using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GWS.Domain.Admin;
using GWS.Hibernate;
using NHibernate;

namespace GWS.Repository.Admin
{
    public class UserRepository
    {
        public static IList<User> GetAll()
        {
            using (var session = SessionFactoryBuilder.GetInstance().OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    return session.CreateCriteria<User>().List<User>();
                }
            }
        }
    }
}
