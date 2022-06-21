using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeginnersApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // MVC service resgistration 
            services.AddMvc(options=>options.EnableEndpointRouting=false);
            //Other way of registering mVC service but need to register other services individually. This service will not bind the view with controller action.
         //   services.AddMvcCore(options=>options.EnableEndpointRouting=false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //middleware for showing the exception page for the developers.
            }

            app.UseStaticFiles();
            //Middleware for enabling the default routing for  MVC
            app.UseMvcWithDefaultRoute();

            //app.UseDefaultFiles();
            //       app.UseStaticFiles();
            //FileServerOptions fileServerOptions = new FileServerOptions();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("home.html");
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("home.htm");

            //app.UseFileServer(fileServerOptions);

        }
    }
}
/*
 *    */