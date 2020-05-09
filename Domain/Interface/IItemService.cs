using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Model;

namespace ToDoList.Domain.Interface
{
    public interface IItemService
    {
        List<Item> GetItems();
        List<Item> PostItem(Item item);
        List<Item> DeleteItem(int idItem);
    }
}
