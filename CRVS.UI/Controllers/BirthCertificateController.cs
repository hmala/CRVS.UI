using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.Core.Models.ViewModels;
using CRVS.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Elfie.Model.Map;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Versioning;
using Microsoft.AspNetCore.Http;
using System.Drawing;

namespace CRVS.UI.Controllers
{
    public class BirthCertificateController : Controller
    {
        public IBaseRepository<BirthCertificate> _BaseRepository;
        public IWebHostEnvironment _environment;
        public ApplicationDbContext _context;
        String fname;


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
            var birth = _context.BirthCertificates.Where(x => x.IsDeleted == false).ToList();
            return View(birth);

        }
        public IActionResult Index1()
        {
            var birth = _context.BirthCertificates.Where(x => x.IsDeleted == true).ToList();
            return View(birth);

        }
        [HttpGet]
        public IActionResult Create(BirthCertificate model)
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
            ViewBag.fname = HttpContext.Session.GetString("Fname");
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

            model.IsReject = false;
             
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

        [HttpGet]
        public IActionResult PreCreate()
        {
           
            var  BirthCertificates = _context.BirthCertificates.ToList();
            return View(BirthCertificates);
           
        }
        [HttpPost]
        public IActionResult PreCreate(BirthCertificate model,DateTime sdate, DateTime edate)
        {

            var BirthCertificates = _context.BirthCertificates.Where(x=> x.BOD>=sdate && x.BOD<=edate).ToList();
            fname = Request.Form["Fname"]!;
            HttpContext.Session.SetString("Fname",fname);
            return RedirectToAction("Create");
            
           


        }
       
    }
}
