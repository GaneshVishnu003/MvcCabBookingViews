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
        public ActionResult SignUp()
        {
            IEnumerable<UserEntityDb> user = UserRepository.GetDetails();
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(UserEntity user)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Success";
            }
            return View(user);
        }
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult DataPassing()
        {
            IEnumerable<CabEntity> cab = CabRepository.GetLocation();
            ViewBag.CabDetails = cab;
            ViewData["cab"] = cab;
            TempData["cab"] = cab;
            return Redirect("Display");
        }
        public ActionResult Display()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateLocation()
        {
            CabEntity cab = new CabEntity();
            UpdateModel(cab);
            //int locationId=cab[
            CabRepository.Add(cab);
            TempData["Result"] = "Added successfully";
            return RedirectToAction("DataPassing");
        } 
        [HttpGet]
        public ActionResult Edit([Bind(Exclude = "LocationId")]int id)
        {
            CabEntity cab = CabRepository.GetLocationById(id);
            return View(cab);
        }
        
        [HttpGet]
        public ActionResult Delete(int id)
        {
            CabRepository.Delete(id);
            TempData["Result"] = "Deleted Successfully";
            return RedirectToAction("DataPassing");
        }
        [HttpPost]
        public ActionResult Update(CabEntity cab)
        {
            int id = cab.LocationId;
            CabRepository.Update(cab);
            return RedirectToAction("DataPassing");
        }
    }
}