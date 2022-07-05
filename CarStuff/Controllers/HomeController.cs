using CarStuff.DAL.Repositories;
using CarStuff.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarStuff.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarPurchaseRepo _carPurchaseRepo;

        public HomeController(ICarPurchaseRepo carPurchaseRepo)
        {
            this._carPurchaseRepo = carPurchaseRepo;
        }

        public IActionResult Index()
        {
            var purchases = _carPurchaseRepo.GetAll().ToList();

            return View(purchases);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}