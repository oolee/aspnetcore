using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace Culture {
    public class Startup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            //app.Use((context, next)=> {
            //    var cultureQuery = context.Request.Query["culture"];

            //    if (!string.IsNullOrEmpty(cultureQuery)) {
            //        var culture = new CultureInfo(cultureQuery);

            //        CultureInfo.CurrentCulture = culture;
            //        CultureInfo.CurrentUICulture = culture;
            //    }

            //  return  next();
            //});

            app.UseRequestCulture();

            app.Run(async (context) => {
                context.Response.ContentType = "text/plain;charset=utf-8;";
                await context.Response.WriteAsync($"Hello World!区域性:{CultureInfo.CurrentCulture.DisplayName}|{CultureInfo.CurrentUICulture.DisplayName}");
            });
        }
    }
}
