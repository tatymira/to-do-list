using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain.Interface
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void BindCurrentSessionContext();
        void Execute();
        ISession CurrentSession { get; }
        void Dispose();
    }
}
