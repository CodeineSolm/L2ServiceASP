using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ASPCoreL2Services.Service;
using ASPCoreL2Services.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPCoreL2Services
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        
        public void ConfigureServices(IServiceCollection services)
        {
            //var connStr = Configuration.GetConnectionString(Config.ConnectingString);
            var connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=L2Services;Integrated Security=True";
            services.AddControllersWithViews().SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
            Configuration.Bind("Project", new Config());
            services.AddDbContext<L2Context>(x => x.UseSqlServer(connStr));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();            
            
            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
