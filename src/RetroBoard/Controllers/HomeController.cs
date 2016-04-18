using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Http.Internal;
using Microsoft.AspNet.Mvc;
using RetroBoard.ViewModels.Home;

namespace RetroBoard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string boardId = null)
        {
            var model = new BoardViewModel
            {
                Categories = new List<CategoryModel>(), //GetSampleData(),
                HasBoard = boardId!=null,
                BoardId = boardId??Guid.NewGuid().ToString(),
                TagColumns = "Done Well,Can Improve,Changes to Make",
            };

            return View(model);
        }

        public IActionResult Board(string tagColumns)
        {
            var categories = tagColumns.Split(',').Take(6).Select(col => new CategoryModel
            {
                Id = Guid.NewGuid(), Title = col.ToString(), Cards = new List<CardModel>(),
            }).ToList();


            var model = new BoardViewModel
            {
                Categories = categories,
                HasBoard = true,
                BoardId = Guid.NewGuid().ToString(),
            };

            return View("Index", model);
        }

        public IActionResult Error()
        {
            return View();
        }


        #region Old Dev Code Test Data

        private List<CategoryModel> GetSampleData()
        {
            return new List<CategoryModel>
            {
                new CategoryModel
                {
                    Id = Guid.NewGuid(),
                    Cards =
                        new List<CardModel>
                        {
                            new CardModel {Id = Guid.NewGuid(), Text = "This is a card."},
                            new CardModel {Id = Guid.NewGuid(), Text = "My idea is different."},
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                        },
                    Color = "#ffffff",
                    Title = "Went Well"
                },
                new CategoryModel
                {
                    Id = Guid.NewGuid(),
                    Cards =
                        new List<CardModel>
                        {
                            new CardModel {Id = Guid.NewGuid(), Text = "This doens't make sense."},
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                        },
                    Color = "#ffffff",
                    Title = "Went Poorly"
                },
                new CategoryModel
                {
                    Id = Guid.NewGuid(),
                    Cards =
                        new List<CardModel>
                        {
                            new CardModel {Id = Guid.NewGuid(), Text = "A stupid idea."},
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                            new CardModel {Id = Guid.NewGuid(), Text = "Some fascinating idea."},
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                            new CardModel {Id = Guid.NewGuid(), Text = "A stupid idea."},
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                            new CardModel {Id = Guid.NewGuid(), Text = "Some fascinating idea."},
                            new CardModel
                            {
                                Id = Guid.NewGuid(),
                                Text =
                                    "A super-weird idea. And not only that, but the person goes on and on and doesn't stop talking.   It's kind of annoying."
                            },
                            new CardModel {Id = Guid.NewGuid(), Text = "A stupid idea."},
                            new CardModel {Id = Guid.NewGuid(), Text = "Some fascinating idea."},
                        },
                    Color = "#ffffff",
                    Title = "Places to Improve"
                }
            };
        }
        #endregion
    }
}
