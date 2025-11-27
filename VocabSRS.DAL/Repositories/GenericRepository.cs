using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabSRS.Core.Entities;
using VocabSRS.Core.Interfaces;
using VocabSRS.DAL.Context;

namespace VocabSRS.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly SqlServerContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(SqlServerContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public T Get(int id)
        {
            T value = _dbSet.Find(id);
            if (value == null)
                throw new System.NullReferenceException();
            return value;
        }

        public List<T> GetAll()
        {
            List<T> values = _dbSet.ToList();
            // Custom exception handling
            return values;
        }

        public void HardDelete(int id)
        {
            T value = _dbSet.Find(id);
            _dbSet.Remove(value);
            _context.SaveChanges();
        }

        public void SoftDelete(int id)
        {
            T value = _dbSet.Find(id);
            value.IsDeleted = true;
            _dbSet.Update(value);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
