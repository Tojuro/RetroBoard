using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using RetroBoard.ViewModels.Home;

namespace RetroBoard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new BoardViewModel
            {
                Categories = new List<CategoryModel>
                {
                    { new CategoryModel
                        {
                            Cards = new List<CardModel>(),
                            Color = "#ffffff",
                            Title = "Went Well"
                        } },
                    { new CategoryModel
                       {
                            Cards = new List<CardModel>(),
                            Color = "#ffffff",
                            Title = "Went Poorly"
                        } },
                    { new CategoryModel
                     {
                            Cards = new List<CardModel>(),
                            Color = "#ffffff",
                            Title = "Places to Improve"
                        } },
                },
            };

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
