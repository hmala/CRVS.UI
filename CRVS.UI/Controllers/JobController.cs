using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.EF.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRVS.UI.Controllers
{
    public class JobController : Controller
    {
        public IBaseRepository<Job> _BaseRepository;
        public JobController(IBaseRepository<Job> BaseRepository)
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
        public IActionResult Create(Job job)
        {


            // Default Values
         


                _BaseRepository.Add(job);
                _BaseRepository.SaveChanges();
                return RedirectToAction("Index");
           
        }
    }
}
