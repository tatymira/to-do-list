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

        
        public List<Item> GetAll()
        {
            return _session.Query<Item>().OrderBy(x => x.Name).ToList();
        }

        public void Post(Item item)
        {
            _unitOfWork.BeginTransaction();
            _session.Save(item);
            _unitOfWork.Execute();
        }

        public void Uptade(Item item)
        {
            _unitOfWork.BeginTransaction();
            _session.Update(item);
            _unitOfWork.Execute();
        }

        public void Delete(int idItem)
        {
            var toRemove = _session.Query<Item>().FirstOrDefault(x => x.Id == idItem);

            _unitOfWork.BeginTransaction();
            _session.Delete(toRemove);
            _unitOfWork.Execute();
        }

    }    
}