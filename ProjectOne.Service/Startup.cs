using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectOne.Entity.MySql;
using ProjectOne.Repository;
using ProjectOne.Service.Middlewares;

namespace ProjectOne.Service
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<MySqlDbContext>(opt => opt.UseMySQL("server=127.0.0.1; user id=root; persistsecurityinfo=true;database=projectone; pwd=123456789"), ServiceLifetime.Transient);
            services.AddTransient<IRepositoryWrapper, RepositoryWrapper>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMiddleware<ExceptionMiddleware>();
            //app.Use(async (context, next) => { await next.Invoke(); });
            app.Map("/home/register",req=>{
                req.UseMiddleware<RegisterMiddleware>().UseMvc(r=>r.MapRoute("register","{controller=home}/{action=register}"));
            });
            
            app.UseMvc(r => { r.MapRoute("default", "{controller=Home}/{action=Index}"); });

            // app.Run(async (context) =>
            // {
            //     await context.Response.WriteAsync("Hello World!");
            // });
        }
    }
}
