using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookStoreCoreApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddMvc();   or
            services.AddControllersWithViews();
            // services.AddControllers(); incase of webapi
        }






        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //application environments
            /* IsDevelopment
             * IsEnvironment
             * IsProduction
             * IsStaging
             */
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async(context, next) => 
            //{
            //    await context.Response.WriteAsync("Middleware request 1");
            //    await next();
            //    await context.Response.WriteAsync("Middleware response 1");
            //});

            //app.Use(async (context, next) =>
            //  {
            //      await context.Response.WriteAsync("Middleware request 2");
            //      await next();
            //      await context.Response.WriteAsync("Middleware response 2");
            //  });
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Middleware request 3");
            //    await next();
            //});

            //we must routing before any usage of actual endpoints routes
            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                // ~/home/index
                endpoints.MapDefaultControllerRoute();
            });


            //app.UseEndpoints(endpoints =>
            //{
            //    //MapGet(): mapping a particular url to a particular resource
            //    //MapGet(): handles only Get request vs Map(): handles all request operations

            //    endpoints.MapGet("/", async context =>
            //    {
            //        //await context.Response.WriteAsync("Hello World!");
            //        if (env.IsDevelopment())
            //        {
            //            await context.Response.WriteAsync("Hello from development");
            //        }
            //        else if (env.IsProduction())
            //        {
            //            await context.Response.WriteAsync("Hello from production");
            //        }
            //        else if (env.IsStaging())
            //        {
            //            await context.Response.WriteAsync("Hello from staging");
            //        }
            //        //else if (env.IsEnvironment("Hello Esraa"))   or
            //        else if (env.EnvironmentName == "Hello Esraa")
            //        {
            //            //await context.Response.WriteAsync(env.EnvironmentName);
            //            await context.Response.WriteAsync("Yes the same");
            //        }
            //    });
            //});
            //output
            //Middleware request 1Middleware request 2Middleware request 3Hello World!Middleware response 2Middleware response 1

            app.UseEndpoints(endpoints =>
            {
                //Esraa: url domain
                endpoints.Map("/Esraa", async context =>
                {
                    await context.Response.WriteAsync("Hello Esraa!");
                });
            });
        }
    }
}
