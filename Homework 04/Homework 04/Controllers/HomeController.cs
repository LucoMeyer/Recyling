using Homework_04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.Message = "Your application description page.";


            return View();
        }

        


        MVCCRUDDGContext _context = new MVCCRUDDGContext();

        public ActionResult NewReduction()
        {



            var listofData = _context.Reducs.ToList();
            return View(listofData);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Create(Reduc model)
        {
            _context.Reducs.Add(model);
            _context.SaveChanges();
            ViewBag.Message = "Weekly data successfully inserted!";
            return View();
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var data = _context.Reducs.Where(x => x.WeekNum == id).FirstOrDefault();
            return View(data);

        }


        [HttpPost]
        public ActionResult Update(Reduc Model)
        {
            var data = _context.Reducs.Where(x => x.WeekNum == Model.WeekNum).FirstOrDefault();

            if (data != null)
            {
                data.KiloNotRecycled = Model.KiloNotRecycled;
                data.Comments = Model.Comments;
                _context.SaveChanges();
            }
            return RedirectToAction("NewReduction");
        }

        public ActionResult Detail(int id)
        {
            var data = _context.Reducs.Where(x => x.WeekNum == id).FirstOrDefault();
            return View(data);

        }

        public ActionResult Delete(int id)
        {
            var data = _context.Reducs.Where(x => x.WeekNum == id).FirstOrDefault();
            _context.Reducs.Remove(data);
            _context.SaveChanges();
            ViewBag.Message = "Record deleted successfully!";
            return RedirectToAction("NewReduction");

        }


        [HttpGet]
        public ActionResult ShowMaterial(int materialType)
        {
            switch (materialType) {
                case 0: // Glass
                    var tobj = new Glass();
                    ViewData["material"] = tobj;
                    ViewData["uniqueMaterial"] = tobj.Opacity;
                    break;
                case 1: // Aliminium                    
                    var tobj1 = new Aluminum();
                    ViewData["material"] = tobj1;
                    ViewData["uniqueMaterial"] = tobj1.RiskLevel;
                    break;
                case 2: // Plastics
                    var tobj2 = new Plastic();
                    ViewData["material"] = tobj2;
                    ViewData["uniqueMaterial"] = tobj2.Sustainable;
                    break;
                case 3: // Batteries
                    var tobj3 = new Battery();
                    ViewData["material"] = tobj3;
                    ViewData["uniqueMaterial"] = tobj3.BatteryType1;
                    break;
            }
                                   
            return View();
        }




        public ActionResult Recycling()
        {
            ViewBag.Message = "Your Recycling page.";

            return View();
        }

        public ActionResult ReUse()
        {
            ViewBag.Message = "Your ReUse page.";

            return View();
        }


       






        public ActionResult Prevention()
        {
            ViewBag.Message = "Your Prevention page.";

            return View();
        }
    }
}