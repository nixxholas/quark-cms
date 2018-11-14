using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delta.DataAccess.Contexts.Trinity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Delta.WebApp
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
            services.AddDbContext<AuthDataContext>(options =>
            {
                var connStr = Configuration.GetConnectionString("Trinity:Auth");
                options.UseSqlServer(connStr);
            });
            services.AddDbContext<CharactersDataContext>(options =>
            {
                var connStr = Configuration.GetConnectionString("Trinity:Characters");
                options.UseSqlServer(connStr);
            });
            services.AddDbContext<HotfixDataContext>(options =>
            {
                var connStr = Configuration.GetConnectionString("Trinity:Hotfixes");
                options.UseSqlServer(connStr);
            });
            services.AddDbContext<WorldDataContext>(options =>
            {
                var connStr = Configuration.GetConnectionString("Trinity:World");
                options.UseSqlServer(connStr);
            });
            
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}