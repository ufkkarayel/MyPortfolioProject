using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolioProject.DAL.Entities
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}