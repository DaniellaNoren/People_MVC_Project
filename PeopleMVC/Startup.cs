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

            services.AddDbContext<PeopleContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PeopleDB")));

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

     
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}
