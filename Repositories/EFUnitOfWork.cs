using Library.EF;
using Library.Entities;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private BlogContext db;
        private ArticleRepository articleRepository;
        private PersonRepository personRepository;
        private CommentRepository commentRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new BlogContext(connectionString);
        }
        IRepository<Article> IUnitOfWork.Articles
        {
            get
            {
                if (articleRepository == null)
                    articleRepository = new ArticleRepository(db);
                return articleRepository;
            }
        }

        IRepository<Person> People
        {
            get
            {
                if (personRepository == null)
                    personRepository = new PersonRepository(db);
                return personRepository;
            }
        }
        IRepository<Comment> IUnitOfWork.Comments
        {
            get
            {
                if (commentRepository == null)
                    commentRepository = new CommentRepository(db);
                return commentRepository;
            }
        }

        IRepository<Person> IUnitOfWork.People => throw new NotImplementedException();

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
}