using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Repository;

namespace ToDoList.App_Start
{
    public class SessionFactory
    {
        public static ISessionFactory GetFactory()
        {
            var configuration = Fluently.Configure()
                .Database(PostgreSQLConfiguration.PostgreSQL82.ConnectionString(x => x.FromConnectionStringWithKey("ElephantSQL"))
                .ShowSql()
                .FormatSql())
                .CurrentSessionContext("web")
                .Mappings(c => c.FluentMappings.AddFromAssemblyOf<ItemMap>());

            return configuration.BuildSessionFactory();

        }
    }
}