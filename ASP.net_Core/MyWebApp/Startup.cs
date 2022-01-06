using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Data;
using MyWebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.AspNetCore.Routing;

namespace MyWebApp
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
            services.AddRazorPages();
            services.AddScoped<IMessage, Helo_Msg2>();
            services.AddDbContext<MyWebAppContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("MyWebAppContext")));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IMessage obj)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            //app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
            Path.Combine(env.ContentRootPath, "Images")),
                RequestPath = "/images"
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                var msg = obj.GetMessage("Raj");
                endpoints.MapGet("/", context => context.Response.WriteAsync(msg));
                endpoints.MapGet("hello", context => context.Response.WriteAsync("Hello from /hello"));

                endpoints.MapGet("hello/{name}", context => context.Response
                            .WriteAsync($"Hello, {context.GetRouteValue("name")}"));
                endpoints.MapGet("square/{number:int}", context =>
                {
                    int number = Convert.ToInt32(context.GetRouteValue("number"));
                    return context.Response.WriteAsync($"The square of {number} is {number * number}");
                });
            });
        }
    }
}
