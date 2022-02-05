using KlassyCafe.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Controllers
{
    public class UserController : Controller
    {
        UserManager<IdentityUser> userManager;
        SignInManager<IdentityUser> Signin;
        public UserController(UserManager<IdentityUser> manager, SignInManager<IdentityUser> sign)
        {
            userManager = manager;
            Signin = sign;
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserModel userModel , string pas)
        {
            var user = new IdentityUser()
            {
                UserName = userModel.FullName,
                Email = userModel.Email

            };

            var result = await userManager.CreateAsync(user, userModel.Password);
            if (result.Succeeded)
            {
                return View("Login", userModel);
            }
            else
                return RedirectToAction("FrmRegister");
            
           

        }

        public IActionResult FrmRegister()
        {
            
            return View();

        }
        
        public IActionResult Login( string ReturnUrl)
        {
            
            return View(new UserModel() { returnUrl = ReturnUrl });//ReturnUrl is constsnt name for variable used with coockies automaticaly when you use that name
        }

        [HttpPost]
        public async Task<IActionResult> Loging(UserModel userModel)
        {
           var user = await userManager.FindByEmailAsync(userModel.Email);
            

            var result3 = await Signin.PasswordSignInAsync(user, userModel.Password, true, false);

            if (string.IsNullOrEmpty(userModel.returnUrl))
                userModel.returnUrl = "~/";

            if (result3.Succeeded)
            {
            return Redirect(userModel.returnUrl);
            }
            else
            {
                return View("Login", userModel);
            }



        }

        public async Task< IActionResult> LogOut()
        {
            await Signin.SignOutAsync();
            return Redirect("~/");
        }
    }
}










//    var password = await userManager.CheckPasswordAsync(user, userModel.Password);
            //var result = await Signin.CanSignInAsync(user);

            //var result1 =  Signin.SignInAsync(user, result, null);

            //var result2 = await Signin.PasswordSignInAsync(userModel.Email, userModel.Password, true, false);