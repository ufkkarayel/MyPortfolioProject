using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolioProject.DAL.Entities
{
    public class About
    {
        public int AboutID { get; set; }
        public string NameSurname { get; set; }
        public string Introduction { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AboutImage { get; set; }
    }
}