using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Factory_Shop.Data.Interfaces;
using Factory_Shop.Models;

namespace Factory_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IMaterials materials;
        private readonly IMatCategory allCategory;


        public HomeController(ILogger<HomeController> logger, IMatCategory allCategory, IMaterials materials)
        {
            this.logger = logger;
            this.allCategory = allCategory;
            this.materials = materials;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       public ViewResult ListMat()
        {
            MatListViewModel Mat = new MatListViewModel();
            Mat.AllMaT = materials.AllMaterials;
            Mat.MatCategory = "cfr";
            return View(Mat);
        }
    }
}