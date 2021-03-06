using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fuela_clients.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Fuela_clients
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            services.AddControllersWithViews();
           services.AddRazorPages().AddRazorRuntimeCompilation();
            //services.AddDbContext<ApplicationDBContext>();
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer("Server =DESKTOP-FA4I5Q1\\SQLEXPRESS; Database = Bookstore; Integrated Security = True; "));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               

            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


           
            //); app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello second");
            //    await next();
            //}
            //);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Custome}/{action=Index}/{id?}");

               
            });
        }
    }
}
