using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Domain.Repositories;
using TimViec.Infrastructure.Context;

namespace TimViec.Infrastructure.Repositories
{
    public class Repo<T> : IRepo<T> where T : class, new()
    {
        private readonly TimViecContext _context;
        DbSet<T> _dbSet;
        public Repo(TimViecContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public bool Add(T entity)
        {
            if (!_dbSet.Any(e => e == entity))
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public bool Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            else { return false; }

        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> getAll()
        {
            return _dbSet.ToList();
        }

        public bool Update(T entity)
        {
            if (_dbSet.Any(e => e == entity))
            {
                _dbSet.Update(entity);
                _context.SaveChanges();
                return true;
            }
            else { return false; }
        }
    }
}
