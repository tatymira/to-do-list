using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Domain.Model
{
    public class Item
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual bool Done { get; set; }

        public Item()
        {

        }

    }
}