using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.Core.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CRVS.UI.Controllers
{
    public class BirthCertificateController : Controller
    {
        public IBaseRepository<BirthCertificate> _BaseRepository;
        public IWebHostEnvironment _environment;
       
        public BirthCertificateController(IBaseRepository<BirthCertificate> BaseRepository,IWebHostEnvironment webHostEnvironment)
        {
            _BaseRepository = BaseRepository;
            _environment = webHostEnvironment;


           
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
        public IActionResult Create(BirthCertificateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string CourseName = UploadedFile(model);
                BirthCertificate courseData = new BirthCertificate
                {
                    ImgBirthCertificate = CourseName,
                   
                };
                _BaseRepository.Add(model);
                _BaseRepository.SaveChanges();
                return RedirectToAction("Create");
            }
            return View(model);
           

        }
        private string UploadedFile(BirthCertificateViewModel CourseInput)
        {
            string wwwPath = this._environment.WebRootPath;
            string contentPath = this._environment.ContentRootPath;

            string path = Path.Combine(this._environment.WebRootPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string fileName = Path.GetFileNameWithoutExtension(CourseInput.ImgBirthCertificate!.FileName);
            string newName = fileName + Guid.NewGuid().ToString() + Path.GetExtension(CourseInput.ImgBirthCertificate.FileName);
            using (FileStream stream = new FileStream(Path.Combine(path, newName), FileMode.Create))
            {
                CourseInput.ImgBirthCertificate.CopyTo(stream);
            }
            return "\\Uploads\\" + newName;
        }
    }
}
