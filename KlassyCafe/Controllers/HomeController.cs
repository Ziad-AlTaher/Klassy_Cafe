using KlassyCafe.Bl;
using KlassyCafe.Models;
using KlassyCafe.NewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Controllers
{
    public class HomeController : Controller
    {
        IReservationService reservationService;
        IEmployeeServic EmpService;
        IitemService ItemService;
        ICategoryService CategoryService;
        ISliderService SliderService;
        public HomeController(IitemService IService, ICategoryService CatService, IEmployeeServic employeeServic, ISliderService slidService, IReservationService reservation)
        {
            ItemService = IService;
            CategoryService = CatService;
            EmpService = employeeServic;
            SliderService = slidService;
            reservationService = reservation;
        }
        public IActionResult Index(TbReservation reserv)
        {
            HomeModel model = new HomeModel();
            model.LstItems = ItemService.GetAll();
            model.LstCheffs = EmpService.GetAllCheffs();
            model.LstCategories = CategoryService.GetAll();
            model.LstSlider = SliderService.GetAll();
            
            return View(model);
            
        }

        public IActionResult Addreservation(int formNGusts, TbReservation reserv)
        {

            reserv.NGuests = formNGusts;
            reserv.TimeSent = DateTime.Now;
            reservationService.Add(reserv);
            return Redirect("Index");
        }



        public IActionResult Error()
        {

            return View();
        }
    }
}
