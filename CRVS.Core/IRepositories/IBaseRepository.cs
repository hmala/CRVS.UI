using CRVS.Core.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.IRepositories
{
    public   interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        IEnumerable<T> GetAll(string v);
       Task<IEnumerable<T>> GetAlAsync();
        void Add(T model);
        void Update(int id,T model);
        void Delete(int id);

        void SaveChanges();
        void Add(BirthCertificateViewModel model);
    }
}
