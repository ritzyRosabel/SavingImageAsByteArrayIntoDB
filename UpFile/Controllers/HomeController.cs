using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpFile.Models;

namespace UpFile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult AddImage()
        {
            Fileu fileu = new Fileu();
            return View(fileu);
        } 
        [HttpPost]
        public ActionResult AddImage(Fileu model, HttpPostedFileBase image1)
        {
            try
            {
             UpContext upContext = new UpContext();
            if(image1!= null)
            {
                model.image = new byte[image1.ContentLength];
                image1.InputStream.Read(model.image, 0, image1.ContentLength);
            }
            upContext.Fileus.Add(model);
            upContext.SaveChanges();
            }
          catch(Exception ex)
            {
                var err = ex.Message;
            }
            return View(model);
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}