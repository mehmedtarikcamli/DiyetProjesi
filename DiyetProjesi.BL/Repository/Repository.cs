using DiyetProjesi.BL.Interfaces;
using DiyetProjesi.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProjesi.BL.Repository
{
    public class Repository <T> : IRepository<T> where T : class
    {
        private static DietProjectDbContext _db = new DietProjectDbContext();
        private DbSet<T> things;

        public Repository()
        {
            things = _db.Set<T>();
        }
        public void Add(T addItem)
        {
            things.Add(addItem);
            _db.SaveChanges();
        }

        public void Update()
        {
            _db.SaveChanges();

        }

        public List<T> GetAll() 
        {
            return things.AsNoTracking().ToList();
        }

        public T GetById(int id)
        {
            return things.Find(id);
        }

        public void Remove(T deleteItem)
        {
            things.Remove(deleteItem);
            _db.SaveChanges();
        }
    }
}
