using HastaneDoktor.Business.Abstract;
using HastaneDoktor.Business.Concrete;
using HastaneDoktor.DataAccess.Abstract;
using HastaneDoktor.DataAccess.Concrete;
using HastaneDoktor.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastaneDoktor.WebApp
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
            services.AddCors();
            services.AddControllers();

            services.AddSingleton<IDoktorRepository, DoktorRepository>();
            services.AddSingleton<IHastaneRepository, HastaneRepository>();
            services.AddSingleton<IDoktorService, DoktorManager>();
            services.AddSingleton<IHastaneService, HastaneManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(
             options => options.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader()
             );

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
