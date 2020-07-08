using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public interface IRepository<T>
    {
        public List<T> List();
        public T Get(int id);
        public void Create(T model);
        public void Edit(T model);
        public void Delete(int id);
        public void SaveChanges();
    }
}
