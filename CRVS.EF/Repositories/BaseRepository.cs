using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.Core.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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



        public void Delete(string CertificateNo)
        {
            var entity = _context.Set<T>().Find(CertificateNo);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                SaveChanges();
            }
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

        public T GetById(string CertificateNo)
        {
            return _context.Set<T>().Find(CertificateNo)!;

        }



        public async Task<T> GetByIdAsync(string CertificateNo)
        {
            return await (_context.Set<T>().FindAsync(CertificateNo));
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(string CertificateNo, T model)
        {
                _context.Set<T>().Update(model);
                SaveChanges();
            }
        }
    }
