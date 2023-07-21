using CRVS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
    
        
        T GetById(string CertificateNo);
        
        IEnumerable<T> GetAll();
       
        void Add(T model);
        void Update(string CertificateNo, T model);
        void Delete(string CertificateNo);

        void SaveChanges();
        
    }
}
