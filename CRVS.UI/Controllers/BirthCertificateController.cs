using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRVS.UI.Controllers
{
    public class BirthCertificateController : Controller
    {
        public IBaseRepository<BirthCertificate> _BaseRepository;
       
        public BirthCertificateController(IBaseRepository<BirthCertificate> BaseRepository)
        {
            _BaseRepository = BaseRepository;

           
        }
        public IActionResult Index()
        {
            return View(_BaseRepository.GetAll);
        }
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(BirthCertificate birthCertificate)
        {


            // Default Values



            _BaseRepository.Add(birthCertificate);
            _BaseRepository.SaveChanges();
            return RedirectToAction("Create");

        }
    }
}
