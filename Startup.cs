using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHomeFinance.DTO;
using WebHomeFinance.Models;
using WebHomeFinance.Repository;

namespace WebHomeFinance
{
    public class Startup
    {       
        public void ConfigureServices(IServiceCollection services)
        {                   
            services.AddDbContext<FinanceDBContext>(options => options.UseSqlServer("DefaultConnection"));
            services.AddControllers();
            services.AddScoped<IRepository<TypeTransaction>, TypeRepository>();
            services.AddScoped<IRepository<NameTransaction>, NameRepository>();
            services.AddScoped<IRepository<RegisterTransaction>, RegisterRepository>();
            services.AddScoped<IRepository<ModelReport>, ReportRepository>();
        }
     
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {            
            app.UseDeveloperExceptionPage();        

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
