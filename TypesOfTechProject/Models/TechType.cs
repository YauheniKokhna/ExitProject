using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypesOfTechProject.Models
{
    public class TechType
    {
        public string Title { get; set; }
        public List<string> Manufacturers { get; set; }

        public TechType()
        {
        }

        public TechType(string title, List<string> manufacturers)
        {
            Title = title;
            Manufacturers = manufacturers;
        }
    }
}