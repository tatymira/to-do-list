using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Domain.Model;

namespace ToDoList.Domain.Interface
{
    public interface IItemRepository
    {
        List<Item> GetAll();
        void Post(Item item);
        void Uptade(Item item);
        void Delete(int idItem);
    }
}