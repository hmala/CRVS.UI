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
            var oddData = _context.Jobs.ToList().Where((c, i) => i % 2 != 0);
            var evnData = _context.Jobs.ToList().Where((c, i) => i % 2 == 0);
            var oddData1 = _context.Religions.ToList().Where((c, i) => i % 2 != 0);
            var evnData1 = _context.Religions.ToList().Where((c, i) => i % 2 == 0);


            ViewBag.Disabledtype = new SelectList(_context.DisabledTypes, "DisabledTypeCode", "DisabledTypeName");
            ViewBag.getjobs = new SelectList(evnData, "JobId", "JobName");
            ViewBag.getjobs1 = new SelectList(oddData, "JobId", "JobName");
            ViewBag.Nationality = new SelectList(_context.Nationalities, "NationalityId", "NationalityName");
            ViewBag.Religion = new SelectList(evnData1, "ReligionId", "ReligionName");
            ViewBag.Religion1 = new SelectList(oddData1, "ReligionId", "ReligionName");

            return View();
        }
        [HttpPost]
        public IActionResult Create(BirthCertificate model,int result,int resultm)
        {
            

            
            

           
            model.FatherAge= result;
                 model.MotherAge= resultm;
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
