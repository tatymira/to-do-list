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
        List<Item> GetAll();
        void Post(Item item);
        void Uptade(Item item);
        void Delete(int idItem);
    }
}
