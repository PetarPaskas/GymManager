using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymManager.ViewModels;
using GymManager.Models;

namespace GymManager.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            var viewModel = new List<IndexShopViewModel>();
            foreach(var product in UnitOfWork.Products)
            {
                viewModel.Add(new IndexShopViewModel()
                {
                    Price = product.Price,
                    Id = product.Id,
                    ImagePath = product.ImagePath,
                    Name = product.Name                     
                });
            }
            return View("ShopIndex", viewModel);
        }


        public ActionResult BuyForm()
        {
            return View();
        }
    }
}