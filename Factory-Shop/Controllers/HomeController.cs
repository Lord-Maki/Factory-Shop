using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Factory_Shop.Data.Interfaces;
using Factory_Shop.Models;
using Factory_Shop.Data.Models;
using System.Net.Mail;

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
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       public ViewResult ListMat(int pg = 1)
       {
            
            MatListViewModel Mat = new MatListViewModel();
            Mat.AllMaT = materials.AllMaterials;
            Mat.MatCategory = "cfr";
            //Grtting dada from data base
            const int pageSize = 4;
            if (pg < 1)
            {
                pg = 1;
            }
            //Setting the number of products per page 
            int recsCount = Mat.AllMaT.Count();
            var paginator = new MatListViewModel(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            MatListViewModel data = new MatListViewModel();
            data.AllMaT = Mat.AllMaT.Skip(recSkip).Take(paginator.PageSize).ToList();
            this.ViewBag.MatListViewModel = paginator;
            return View(data);
            //Enable pagination
            
                       
       }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}