using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using ToDoList.Repository;

namespace ToDoList.App_Start
{
    public class SessionFactory
    {
        public static ISessionFactory GetFactory()
        {
            var connect = PostgreSQLConfiguration.PostgreSQL82.ConnectionString(x => x.FromConnectionStringWithKey("ElephantSQL"));
            var configuration = Fluently.Configure()
                .Database(connect
                .ShowSql()
                .FormatSql())
                .CurrentSessionContext("web")
                .Mappings(c => c.FluentMappings.AddFromAssemblyOf<ItemMap>());

            return configuration.BuildSessionFactory();

        }
    }
}