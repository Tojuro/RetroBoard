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
                            Id = Guid.NewGuid(),
                            Cards = new List<CardModel> { new CardModel { Id = Guid.NewGuid(), Text = "This is a card."}, new CardModel { Id = Guid.NewGuid(), Text = "My idea is different."},   },
                            Color = "#ffffff",
                            Title = "Went Well"
                        } },
                    { new CategoryModel
                       {
                            Id = Guid.NewGuid(),
                            Cards = new List<CardModel> { new CardModel { Id = Guid.NewGuid(), Text = "This doens't make sense."}, new CardModel { Id = Guid.NewGuid(), Text = "A super-weird idea."},   },
                            Color = "#ffffff",
                            Title = "Went Poorly"
                        } },
                    { new CategoryModel
                     {
                            Id = Guid.NewGuid(),
                            Cards = new List<CardModel> { new CardModel { Id = Guid.NewGuid(), Text = "A stupid idea."}, new CardModel { Id = Guid.NewGuid(), Text = "Some fascinating idea."},   },
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
