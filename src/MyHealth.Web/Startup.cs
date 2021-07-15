using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyHealth.Web.AppBuilderExtensions;
using MyHealth.Model;

using MyHealth.Data;
using MyHealth.API.Infrastructure;
using Microsoft.Extensions.Configuration;
using MyHealth.Data.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore.SqlServer;
//using IdentityRole = Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole;

namespace MyHealth.Web
{
    public class Startup
    {
        public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            //if (env.IsDevelopment())
            //{
                //builder.AddUserSecrets("");
                //builder.AddApplicationInsightsSettings(developerMode: true);
            //}

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<MyHealthContext>(options => options.UseSqlServer(connection));

            // Register dependencies
            services.ConfigureDependencies();

            // Add Identity services to the services container.
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<MyHealthContext>()
                //.AddUserStore<MyHealthContext>()
                .AddDefaultTokenProviders();

            //services.AddApplicationInsightsTelemetry(Configuration);


            // Add MVC services to the services container.
            services.AddMvc(opt=> opt.EnableEndpointRouting=false);

            services.AddMemoryCache();

            services.AddSession();

            services.AddAuthorization(Policies.Configuration);

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async  void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory, 
            MyHealthDataInitializer dataInitializer)
        {
            // Add Application Insights monitoring to the request pipeline as a very first middleware.
            //app.UseApplicationInsightsRequestTelemetry();

            //loggerFactory.AddConsole();

            // Add the following to the request pipeline only in development environment.
            //if (env.IsDevelopment())
            //{
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //}

            // Add Application Insights exceptions handling to the request pipeline.
            //app.UseApplicationInsightsExceptionTelemetry();

            // Add static files to the request pipeline.
            app.UseStaticFiles();

            app.UseSession();

            app.UseAuthentication();

            //app.ConfigureSecurity();

            // Add MVC to the request pipeline.
            app.ConfigureRoutes();

            await dataInitializer.InitializeDatabaseAsync(app.ApplicationServices);

        }
    }
}
