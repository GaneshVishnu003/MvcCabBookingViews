using CabBookingDAL;
using CabBookingEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCabBooking.Controllers
{
    public class CabController : Controller
    {
        // GET: Cab
        public ActionResult Index()
        {
            IEnumerable<CabEntity> cabEntities = CabRepository.GetLocation();
            return View(cabEntities);
        }
        public ActionResult DataPassing()
        {
            IEnumerable<CabEntity> cab = CabRepository.GetLocation();
            ViewBag.CabDetails = cab;
            ViewData["cab"] = cab;
            TempData["cab"] = cab;
            return View(cab);
        }
    }
}