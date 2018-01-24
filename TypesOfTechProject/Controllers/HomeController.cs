using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using TypesOfTechProject.Models;
using System.Xml.XPath;
using System.IO;

namespace TypesOfTechProject.Controllers
{
    public class HomeController : Controller
    {
        List<string> motoManufacturers = new List<string>();

        public HomeController()
        {
            //motoManufacturers.Add("Honda");
            //motoManufacturers.Add("Kawasaki");
            //motoManufacturers.Add("Suzuki");
            //motoManufacturers.Add("Harley-Davidson");

            var document = new XPathDocument("http://localhost:56032/Moto_Manufacturers.xml");//указываем абсолютный путь, т.к. если указать относительный - нужно указывать путь относительно папки IIS Express на локальной машине, что также требует проверки
            XPathNavigator navigator = document.CreateNavigator();

            XPathNodeIterator iterator1 = navigator.Select("List/Title");
            while (iterator1.MoveNext())
            {
                motoManufacturers.Add(iterator1.Current.ToString());
            }
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult GetContent()
        {
            return Json(motoManufacturers, JsonRequestBehavior.AllowGet);
        }
    }
}