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
       

        public IActionResult Index( )
        {
            var birth= _context.BirthCertificates.Where(x=>x.IsDeleted==false).ToList();
            return View(birth);
           
        }
        public IActionResult Index1()
        {
            var birth = _context.BirthCertificates.Where(x => x.IsDeleted == true).ToList();
            return View(birth);

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
        public IActionResult Create(BirthCertificate model,int result,int resultm,string fullname, bool IsDisabled)
        {
                 
                 model.FatherFullName = fullname;
                 model.FatherAge= result;
                 model.MotherAge= resultm;
                 model.IsDisabled= IsDisabled;
                _BaseRepository.Add(model);
                _BaseRepository.SaveChanges();
                return RedirectToAction("Index");
            
         


        }
        [HttpGet]
        public IActionResult Edit(string CertificateNo)
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

            BirthCertificate birth =  _BaseRepository.GetAll().Where(x=>x.CertificateNo==CertificateNo).SingleOrDefault()!;
            
                return View(birth);

            
        }

        [HttpPost]
        public  IActionResult Edit(string CertificateNo,BirthCertificate model)
        {


            _BaseRepository.Update(CertificateNo,model);

            return RedirectToAction("Index");


        }
        [HttpGet]
        public IActionResult Details(string CertificateNo)
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

            BirthCertificate birth = _BaseRepository.GetAll().Where(x => x.CertificateNo == CertificateNo).SingleOrDefault()!;

            return View(birth);
        }
        [HttpGet]
        public IActionResult Delete(string CertificateNo)
        {
            var birth = _BaseRepository.GetAll().Where(x => x.CertificateNo == CertificateNo).SingleOrDefault()!;
            _context.BirthCertificates.Remove(birth);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
