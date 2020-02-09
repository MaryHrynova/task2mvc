using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    interface IUnitOfWork : IDisposable
    {
        IRepository<Article> Articles { get; }
        IRepository<Person> People { get; }
        IRepository<Comment> Comments { get; }
        void Save();
    }
}
