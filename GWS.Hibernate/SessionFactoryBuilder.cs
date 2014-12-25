using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;

namespace GWS.Hibernate
{
    public class SessionFactoryBuilder
    {
        private ISessionFactory _sessionfactory;

        private ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionfactory == null)
                    _sessionfactory = BuildFactory();
                return _sessionfactory;
            }
        }

        private ISessionFactory BuildFactory()
        {
            try
            {
                Configuration cfg = null;
                cfg = Fluently.Configure()
                        .Database(MsSqlConfiguration.MsSql2008.ConnectionString(
                        @"Server=HAILMARY\HAILMARY;Database=DB_Joshua;User Id=test;Password=test;").ShowSql())                    
                   /* .ExposeConfiguration(
                        c =>
                        {
                            c.SetProperty("current_session_context_class", "web");
                            c.SetProperty("cache.provider_class", "NHibernate.Cache.HashtableCacheProvider");
                            c.SetProperty("cache.use_second_level_cache", "false");
                            c.SetProperty("cache.use_query_cache", "false");
                            c.SetProperty("show_sql", "true");
                            c.SetInterceptor(new NHSQLInterceptor());
                        })*/
                    // .ExposeConfiguration(config => new SchemaExport(config).Create(true, true))
                        .Mappings(m => m.FluentMappings.AddFromAssembly(GetType().Assembly))
                        .BuildConfiguration();

                return cfg.BuildSessionFactory();
            }
            // catch (Exception ex) { throw new Exception(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static SessionFactoryBuilder GetInstance()
        {
            return new SessionFactoryBuilder();
        }

        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}