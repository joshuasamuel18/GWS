using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace GWS.Hibernate
{
   public class NHSQLInterceptor
    {
       //NHibernate.SqlCommand.SqlString
       //    IInterceptor.OnPrepareStatement
       //        (NHibernate.SqlCommand.SqlString sql)
       //{
       //    NHSQL.NHibernateSQL = sql.ToString();
       //    return sql;
       //}
    }

   public static class NHSQL
   {
       public static string NHibernateSQL { get; set; }
   }
}
