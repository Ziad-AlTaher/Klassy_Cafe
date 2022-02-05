using KlassyCafe.Bl;
using KlassyCafe.Migrations;
using KlassyCafe.Models;
using KlassyCafe.NewModel;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe
{
    public class Startup
    {
        IConfiguration config;
        public Startup(IConfiguration configuration)
        {
            config = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddHttpContextAccessor();

            //database at json file 
            services.AddDbContext<KlassyCafeContext>(options => options.UseSqlServer(config.GetConnectionString("DefultConnection"))); ;

            services.AddMvc().AddSessionStateTempDataProvider();
            //to use sessions
            services.AddSession();
            //for routing
            services.AddControllersWithViews();
            //dependancy injection
            services.AddScoped<IJopsService, ClsJops>();
            services.AddScoped<IitemService, ClsItems>();
            services.AddScoped<ICategoryService, ClsCategories>();
            services.AddScoped<ISliderService, ClsSlider>();
            services.AddScoped<IEmployeeServic, ClsEmployee>();
            services.AddScoped<IReservationService, ClsReservation>();

            //for identity 
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<KlassyCafeContext>();

            services.ConfigureApplicationCookie(option =>
            {
                option.AccessDeniedPath = "/Home/Error";
                option.Cookie.Name = "Cookie";
                option.Cookie.HttpOnly = true;
                option.ExpireTimeSpan = TimeSpan.FromMinutes(600);
                option.LoginPath = "/User/Login";
                option.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                option.SlidingExpiration = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //App Use
            
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            //End app use
            app.UseEndpoints(endpoints =>
            {
                //Area routing ....
                //endpoints.MapControllerRoute(
                //name: "areas",
                //pattern: "{area:exists}/{controller=Home}/{action=Index}");

                ////Routing...
                //endpoints.MapControllerRoute(
                //        name: "default",
                //        pattern: "{controller=Home}/{action=Index}/{id?}");
                //End Routing
                app.UseEndpoints(endpoints =>
                {
                endpoints.MapAreaControllerRoute(
                "Admin",
                "Admin",
                "Admin/{controller=Home}/{action=Dashbord}/{id?}");
                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
                });
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
