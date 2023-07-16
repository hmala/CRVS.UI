using CRVS.Core.IRepositories;
using CRVS.Core.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(T model)
        {
            _context.Set<T>().Add(model);
            SaveChanges();
        }

      
        public void Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                SaveChanges();
            }
        }

        public Task<IEnumerable<T>> GetAlAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<T> GetAll(string v)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id)!;

        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await (_context.Set<T>().FindAsync(id));
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(int id, T model)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                _context.Set<T>().Update(entity);
                SaveChanges();
            }


        }
    }
}
