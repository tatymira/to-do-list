using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Domain.Model;

namespace ToDoList.Repository
{
    public class ItemMap : ClassMap<Item>
    {
        public ItemMap()
        {
            Id(c => c.Id).Column("id").GeneratedBy.Identity();
            Map(c => c.Name).Column("name");
            Map(c => c.Done).Column("done");

            Table("item");
        }
    }
}