using KlassyCafe.Bl;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ReservationController : Controller
    {
        IReservationService resService;
        public ReservationController(IReservationService reserve)
        {
            resService = reserve;
        }
        public IActionResult List()
        {
            return View(resService.GetAll());
        }

        public IActionResult Decline(int resId, string date)
        {
            resService.Delete(resId, date);
           return(RedirectToAction("List"));
        }
    }
}
