using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GWS.Hibernate;
using NHibernate;
using GWS.Repository.Interfaces;

namespace GWS.Repository
{
    public class BaseRepository:IBaseRepository
    {

        #region Create operations

        public static void Save<T>(T entity)
        {
            using (var session = SessionFactoryBuilder.GetInstance().OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.SaveOrUpdate(entity);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        #endregion


        #region Read operations

        public IList<T> GetAll<T>()
        {
            using (var session = SessionFactoryBuilder.GetInstance().OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var criteria = session.CreateCriteria(typeof(T));
                    return criteria.List<T>();
                }
            }
        }

        #endregion
    }
}
