using System;
using System.Collections.Generic;
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
                HasBoard = boardId==null,
                BoardId = boardId??Guid.NewGuid().ToString(),
            };

            return View(model);
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
