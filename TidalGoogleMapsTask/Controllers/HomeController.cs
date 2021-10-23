using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GoogleMapsTask.Core.Entities;
using GoogleMapsTask.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TidalGoogleMapsTask.Models;

namespace TidalGoogleMapsTask.Controllers
{
    public class HomeController : Controller
        
    {
        private readonly IGenericRepository<UserLocation> userLocationRepository;
        

        public HomeController(IGenericRepository<UserLocation> userLocationRepository)
        {
            this.userLocationRepository = userLocationRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Key = "AIzaSyD_N1k4WKCdiZqCIjjgO0aaKz1Y19JqYqw";
            return View();
        }
        [HttpPost]
        public JsonResult SaveUserLocation(UserLocationVM userLocationVM)
        {
            UserLocation userLocation = new UserLocation
            {
                latitude = userLocationVM.lat,
                longitude = userLocationVM.lng,

            };
            try
            {
                 userLocationRepository.Add(userLocation);
                userLocationRepository.SaveChanges();
                return Json(new { Message = "Location Saved Sucessfuly" });
            }
            catch
            {
                return Json(new  { Message = " Could Not Save Location" });
            }
           

        }

      
    }
}
