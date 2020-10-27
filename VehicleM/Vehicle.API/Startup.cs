using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Vehicle.API.Utility;
using Vehicle.Business.Repositories;
using Vehicle.Data;

namespace Vehicle.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //Dang ky service
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<VehicleDbContext>(context => 
                            context.UseSqlServer(Configuration.GetConnectionString("VehicleDbContext")));
            //services.AddTransient<>  //Dang ky dependency injection
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IModelsRepository, ModelsRepository>();
            services.AddScoped<IAppraisalRepository, AppraisalRepository>();
            services.AddScoped<IMakesRepository, MakesRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
