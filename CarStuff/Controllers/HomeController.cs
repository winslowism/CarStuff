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

        [HttpPost]
        public IActionResult Index(FormModel model)
        {
            var purchases = _carPurchaseRepo.GetAll();

            //if (model.Clear)
            //{
            //    ViewData.Clear();
            //    return View(purchases);
            //}

            if (!string.IsNullOrWhiteSpace(model.CustomerName))
                purchases = purchases.Where(x => x.Customer.FirstName.ToLower().Contains(model.CustomerName.Trim().ToLower()));

            if (!string.IsNullOrWhiteSpace(model.CustomerStreet))
                purchases = purchases.Where(x => x.Customer.Address.Street.ToLower().Contains(model.CustomerStreet.Trim().ToLower()));

            if (!string.IsNullOrWhiteSpace(model.SalesPersonName))
                purchases = purchases.Where(x => x.SalesPerson.Name.ToLower().Contains(model.SalesPersonName.Trim().ToLower()));

            ViewBag.CustomerName = model.CustomerName;
            ViewBag.CustomerStreet = model.CustomerStreet;
            ViewBag.SalesPersonName = model.SalesPersonName;

            return View(purchases.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}