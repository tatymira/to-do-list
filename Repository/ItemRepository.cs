using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Domain.Interface;
using ToDoList.Domain.Model;

namespace ToDoList.Repository
{

    public class ItemRepository : IItemRepository
    {

        private UnitOfWork _unitOfWork;
        public ItemRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }
        protected ISession _session { get { return _unitOfWork.CurrentSession; } }

        public List<Item> GetItems()
        {
            var list = _session.Query<Item>().OrderBy(x => x.Name).ToList();
            return list;
        }

        public List<Item> DeleteItem(int idItem)
        {
            throw new NotImplementedException();
        }
        
        public List<Item> PostItem(Item item)
        {
            throw new NotImplementedException();
        }
    }    
}