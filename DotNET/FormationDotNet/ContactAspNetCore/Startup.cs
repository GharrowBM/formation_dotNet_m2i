using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactAspNetCore
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
            services.AddControllersWithViews();
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "listContact",
                    pattern: "liste-contact", defaults: new {controller = "Contact", action="List"});

                endpoints.MapControllerRoute(
                    name: "detailContact",
                    pattern: "detail-contact", defaults: new { controller = "Contact", action = "Detail" });
                endpoints.MapControllerRoute(
                    name: "formContact",
                    pattern: "formulaire-contact", defaults: new { controller = "Contact", action = "Form" });
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Contact}/{action=List}/{id?}");
            });
        }
    }
}
