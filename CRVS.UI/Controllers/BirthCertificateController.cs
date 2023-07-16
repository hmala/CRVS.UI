using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.Core.Models.ViewModels;
using CRVS.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace CRVS.UI.Controllers
{
    public class BirthCertificateController : Controller
    {
        public IBaseRepository<BirthCertificate> _BaseRepository;
        public IWebHostEnvironment _environment;
        public ApplicationDbContext _context;
           
            

        public BirthCertificateController(IBaseRepository<BirthCertificate> BaseRepository,
            ApplicationDbContext context,
            IWebHostEnvironment webHostEnvironment)
        {
            _BaseRepository = BaseRepository;

            _environment = webHostEnvironment;
            _context = context;
           
        }
        [HttpGet]
       

        public IActionResult Index()
        {
            return View(_BaseRepository.GetAll);
           
        }
     

        [HttpGet]
        public IActionResult Create()
        {

            ViewBag.Disabledtype = new SelectList(_context.DisabledTypes, "DisabledTypeCode", "DisabledTypeName");
            ViewBag.getjobs = new SelectList(_context.Jobs, "JobId", "JobName");
            ViewBag.Nationality = new SelectList(_context.Nationalities, "NationalityId", "NationalityName");
            ViewBag.Religion = new SelectList(_context.Religions, "ReligionId", "ReligionName");

            return View();
        }
        [HttpPost]
        public IActionResult Create(BirthCertificate model)
        {
           
                _BaseRepository.Add(model);
                _BaseRepository.SaveChanges();
                return RedirectToAction("Create");
            
         


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
