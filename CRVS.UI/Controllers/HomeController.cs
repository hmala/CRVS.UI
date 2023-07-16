using CRVS.Core.Models;
using CRVS.EF;
using CRVS.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace CRVS.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
          public IActionResult FiltterData()
        {
            List<Governorate> categorylist = new List<Governorate>();

            categorylist = _context.Governorates.ToList();

          categorylist.Insert(0, new Governorate 
          { 
              GovernorateId = 0,
              GovernorateName = "Select Governorate"
          });

            ViewBag.ListofCategory = categorylist;
            return View();
        }

        [HttpPost]
        public IActionResult FiltterData(Governorate objcategory, FormCollection formCollection)
        {

            if (objcategory.GovernorateId == 0)
            {
                ModelState.AddModelError("", "Select Category");
            }
            else if (objcategory.DohId == 0)
            {
                ModelState.AddModelError("", "Select SubCategory");
            }
            else if (objcategory.DistrictId == 0)
            {
                ModelState.AddModelError("", "Select District");
            }

            var SubCategoryID = HttpContext.Request.Form["DohId"].ToString();
            var ProductID = HttpContext.Request.Form["DistrictId"].ToString();
            //  var ProductID = HttpContext.Request.Form["ProductID"].ToString();

            List<Governorate> categorylist = new List<Governorate>();
            categorylist = (from Governorate in _context.Governorates
                            select Governorate).ToList();
            categorylist.Insert(0, new Governorate { GovernorateId = 0, GovernorateName = "Select" });

            ViewBag.ListofCategory = categorylist;
            return View(objcategory);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public JsonResult GetSubCategory(int CategoryId)
        {
            List<Doh> subCategorylist = new List<Doh>();
            subCategorylist = (from subcategory in _context.Dohs
                               where subcategory.GovernorateId== CategoryId
                               select subcategory).ToList();
            subCategorylist.Insert(0, new Doh { DohId = 0, DohName = "Select" });


            return Json(new SelectList(subCategorylist, "DohId", "DohName"));
        }
        public JsonResult GetProducts(int SubCategoryID)
        {
            List<District> productList = new List<District>();
            productList = (from product in _context.Districts
                           where product.DistrictId == SubCategoryID
                           select product).ToList();
            productList.Insert(0, new District { DistrictId = 0, DistrictName = "Select" });

            return Json(new SelectList(productList, "DistrictId", "DistrictName"));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}