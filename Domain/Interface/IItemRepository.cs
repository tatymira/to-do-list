using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Domain.Model;

namespace ToDoList.Domain.Interface
{
    public interface IItemRepository
    {
        List<Item> GetItems();
        List<Item> PostItem(Item item);
        List<Item> DeleteItem(int idItem);
    }
}