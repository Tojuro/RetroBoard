﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RetroBoard.ViewModels.Home
{
    public class CardModel
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string Contributor { get; set; }
    }

    public class CategoryModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public List<CardModel> Cards { get; set; } 
    }

    public class BoardViewModel
    {
        public List<CategoryModel> Categories;
        public bool HasBoard;
        public string BoardId;
        public string TagColumns;
    }
}
