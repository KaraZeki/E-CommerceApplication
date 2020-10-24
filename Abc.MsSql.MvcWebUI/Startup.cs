using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.MsSql.Business.Abstract;
using Abc.MsSql.Business.Concrete;
using Abc.MsSql.DataAccess.Abstract;
using Abc.MsSql.DataAccess.Concrete.EntityFramework;
using Abc.MsSql.MvcWebUI.Entities;
using Abc.MsSql.MvcWebUI.Middlewares;
using Abc.MsSql.MvcWebUI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Abc.MsSql.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //DEPENDENCY INJECTION  ÝÞLEMLERÝ BURADA YAPILIR ÖR: services.AddMvc
            services.AddScoped<ICategoryServices, CategoryManager>();
            services.AddScoped<IProductServices, ProductManager>();

            services.AddSingleton<ICartService, CartManager>();
            services.AddSingleton<ICartSessionService, CartSessionManager>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<IProductDal, EfProductDal>();


            //Identity User clasýnýn database baðlantý iþlemi
            services.AddDbContext<CustomIdentityDbContext> 
                (options => options.UseSqlServer("Server=DESKTOP-9JQOHOM; Database = ECommerceProject; Trusted_Connection = True"));


            //burada Identtiy user ile beraber kullnaýlacak sýnýflarýmýz da ekliyoruz
            services.AddIdentity<CustomIdentityUser, CustomIdentitiyRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext>()
                .AddDefaultTokenProviders();//kullanýcý bilgilerinin sayfalar arasýnda geçiþ yaparken kullanýlan servis.

            services.Configure<IdentityOptions>(options =>
            {
                //password
                options.Password.RequireDigit = true;//mutlaka numerik karakter girilmeli
                options.Password.RequireLowercase = true;//mutlaka küçük harf girilmeli;
                options.Password.RequireUppercase = true;//mutlaka büyük harf girilmeli;
                options.Password.RequiredLength = 6; //mutlaka 6 karakter olmalý
                options.Password.RequireNonAlphanumeric = false; //alfa numerik girmek zorunda olmaz

                options.Lockout.MaxFailedAccessAttempts = 5; // en fazla beþ kere yanlýþ þifre deneyebilir.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // 5 dakika sonra tekrar þifre deneyebilir

                // options.User.AllowedUserNameCharacters = ""; // kullanýcý adý içerisinde alýnmasý istenmeyen karkterler  örnek "ý,þ,ç,ð,ö".
                options.User.RequireUniqueEmail = true; // ayný mail ile bir daha  hesap oluþturmaz

                options.SignIn.RequireConfirmedEmail = true; //mail ile doðrulama gerçekleþtirir.
                options.SignIn.RequireConfirmedPhoneNumber = false;//telefon doðrulamasý kapalý
            });





            services.AddSession(); //Session kullanmak için import etmemiz lazým 
            services.AddDistributedMemoryCache(); //bunu eklemezsek session aktifleþtirilmedi hatasý alýrýz.
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseFileServer();
            app.UseNodeModules(env.ContentRootPath);//bu middleware nodel_modules klasörünün wwwroot klasörüne yönlendirmek için yazýldý

            app.UseAuthentication(); //Identity servisini kullanmak için. Not .netcore 2.2 versiyonundan önce UseIdentity kullanýlýyordu. Sonraki versiyonlarda deðiþti.
            app.UseSession();
            app.UseMvcWithDefaultRoute(); //Default olarak Home/Index sayfasýný açar.

        }
    }
}
