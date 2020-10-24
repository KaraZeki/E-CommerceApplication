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
            //DEPENDENCY INJECTION  ��LEMLER� BURADA YAPILIR �R: services.AddMvc
            services.AddScoped<ICategoryServices, CategoryManager>();
            services.AddScoped<IProductServices, ProductManager>();

            services.AddSingleton<ICartService, CartManager>();
            services.AddSingleton<ICartSessionService, CartSessionManager>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<IProductDal, EfProductDal>();


            //Identity User clas�n�n database ba�lant� i�lemi
            services.AddDbContext<CustomIdentityDbContext> 
                (options => options.UseSqlServer("Server=DESKTOP-9JQOHOM; Database = ECommerceProject; Trusted_Connection = True"));


            //burada Identtiy user ile beraber kullna�lacak s�n�flar�m�z da ekliyoruz
            services.AddIdentity<CustomIdentityUser, CustomIdentitiyRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext>()
                .AddDefaultTokenProviders();//kullan�c� bilgilerinin sayfalar aras�nda ge�i� yaparken kullan�lan servis.

            services.Configure<IdentityOptions>(options =>
            {
                //password
                options.Password.RequireDigit = true;//mutlaka numerik karakter girilmeli
                options.Password.RequireLowercase = true;//mutlaka k���k harf girilmeli;
                options.Password.RequireUppercase = true;//mutlaka b�y�k harf girilmeli;
                options.Password.RequiredLength = 6; //mutlaka 6 karakter olmal�
                options.Password.RequireNonAlphanumeric = false; //alfa numerik girmek zorunda olmaz

                options.Lockout.MaxFailedAccessAttempts = 5; // en fazla be� kere yanl�� �ifre deneyebilir.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // 5 dakika sonra tekrar �ifre deneyebilir

                // options.User.AllowedUserNameCharacters = ""; // kullan�c� ad� i�erisinde al�nmas� istenmeyen karkterler  �rnek "�,�,�,�,�".
                options.User.RequireUniqueEmail = true; // ayn� mail ile bir daha  hesap olu�turmaz

                options.SignIn.RequireConfirmedEmail = true; //mail ile do�rulama ger�ekle�tirir.
                options.SignIn.RequireConfirmedPhoneNumber = false;//telefon do�rulamas� kapal�
            });





            services.AddSession(); //Session kullanmak i�in import etmemiz laz�m 
            services.AddDistributedMemoryCache(); //bunu eklemezsek session aktifle�tirilmedi hatas� al�r�z.
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
            app.UseNodeModules(env.ContentRootPath);//bu middleware nodel_modules klas�r�n�n wwwroot klas�r�ne y�nlendirmek i�in yaz�ld�

            app.UseAuthentication(); //Identity servisini kullanmak i�in. Not .netcore 2.2 versiyonundan �nce UseIdentity kullan�l�yordu. Sonraki versiyonlarda de�i�ti.
            app.UseSession();
            app.UseMvcWithDefaultRoute(); //Default olarak Home/Index sayfas�n� a�ar.

        }
    }
}
