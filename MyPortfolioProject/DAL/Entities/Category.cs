﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolioProject.DAL.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Project> Projects { get; set; }
    }
}