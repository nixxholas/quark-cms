using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delta.Core;
using Delta.Core.Bus;
using Delta.Core.Notifications;
using Delta.DataAccess;
using Delta.DataAccess.Contexts.Trinity;
using Delta.DataAccess.Interfaces;
using Delta.DataAccess.Repositories.Auth;
using Delta.DataAccess.Repositories.Auth.Interfaces;
using Delta.Querying;
using Delta.Querying.Commands.Auth;
using Delta.Querying.Commands.Auth.Handlers;
using Delta.Service.Trinity.Services;
using Delta.Service.Trinity.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

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
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            
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
            
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            
            // Services
            services.AddScoped<IAccountService, AccountService>();
            
            // Domain Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            // Domain Commands
            services.AddScoped<IRequestHandler<CreateNewAccountCommand>, AccountCommandHandler>();
            
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork<AuthDataContext>>();
            services.AddScoped<IUnitOfWork, UnitOfWork<CharactersDataContext>>();
            services.AddScoped<IUnitOfWork, UnitOfWork<HotfixDataContext>>();
            services.AddScoped<IUnitOfWork, UnitOfWork<WorldDataContext>>();
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
            services.AddSwaggerGen(swaggerGenOptions =>
            {
                swaggerGenOptions.SwaggerDoc(GlobalApiVariables.CURRENT_API_VERSION, new Info
                {
                    Version = GlobalApiVariables.CURRENT_API_VERSION,
                    Title = "Delta API v1",
                    Description = "Reference documentation for the usage of Nozomi.",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Nicholas Chen",
                        Email = "nicholas@counter.network",
                        Url = "https://twitter.com/nixxholas"
                    },
                    License = new License
                    {
                        Name = "Copyright (C) Hayate Inc. - All Rights Reserved",
                        Url = ""
                    }
                });
                
                swaggerGenOptions.EnableAnnotations();
            });
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