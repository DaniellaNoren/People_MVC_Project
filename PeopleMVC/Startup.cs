using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PeopleMVC.Data.DataBase;
using PeopleMVC.Models.DataManagement;
using PeopleMVC.Models.Services;
using Microsoft.Extensions.Configuration;
using PeopleMVC.Data.DataManagement;
using PeopleMVC.Data.Services.Countries;
using PeopleMVC.Data.DataManagement.Countries;
using PeopleMVC.Data.Services.Cities;
using PeopleMVC.Data.DataManagement.Cities;
using PeopleMVC.Data.Services.Languages;
using PeopleMVC.Data.DataManagement.Languages;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Identity;
using PeopleMVC.Data;
using PeopleMVC.Data.Services.User;
using PeopleMVC.Data.DataManagement.User;

namespace PeopleMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleRepo, DatabasePeopleRepo>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICountryRepo, DatabaseCountryRepo>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<ICityRepo, DatabaseCityRepo>();
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<ILanguageRepo, DatabaseLanguageRepo>();
            services.AddScoped<IUserService, UserService>();

            services.AddDbContext<PeopleContext>(options =>
            {
                options.UseSqlServer(
Configuration.GetConnectionString("PeopleDB")).EnableSensitiveDataLogging();

            });

            services.Configure<IdentityOptions>(options =>
            {

                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 1;
                options.Password.RequiredUniqueChars = 0;


                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
            });

            services.AddControllersWithViews(op => op.Filters.Add(new AuthorizeFilter()));

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllPolicy",
                                    builder =>
                                    {
                                        builder.AllowAnyOrigin()
                                                            .AllowAnyHeader()
                                                            .AllowAnyMethod();
                                    });
            });
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env
           )
        {
           

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options =>
            {
                options.AllowAnyHeader();
                options.AllowAnyMethod();
                options.AllowAnyOrigin();
            });


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            
        }
    }
}
