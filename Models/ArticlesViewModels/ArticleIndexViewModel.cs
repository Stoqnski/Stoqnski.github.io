﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog3.Models.ArticlesViewModels
{
    public class ArticleIndexViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string AuthorFullName { get; set; } 
    }
}
