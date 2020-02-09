using Library.EF;
using Library.Entities;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library.Repositories
{
    public class PersonRepository : IRepository<Person>
    {
        private BlogContext db;

        public PersonRepository(BlogContext context)
        {
            this.db = context;
        }

        public IEnumerable<Person> GetAll()
        {
            return db.People.Include(o => o.Name);
        }

        public Person Get(int id)
        {
            return db.People.Find(id);
        }

        public void Create(Person person)
        {
            db.People.Add(person);
        }

        public void Update(Person order)
        {
            db.Entry(order).State = EntityState.Modified;
        }
        public IEnumerable<Person> Find(Func<Person, Boolean> predicate)
        {
            return db.People.Include(o => o.Name).Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Person order = db.People.Find(id);
            if (order != null)
                db.People.Remove(order);
        }
    }
}