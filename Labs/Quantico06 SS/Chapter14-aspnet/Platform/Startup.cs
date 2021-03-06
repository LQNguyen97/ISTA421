using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using Platform.Services;

namespace Platform
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IResponseFormatter, HtmlResponseFormatter>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
        IResponseFormatter formatter)
        {
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseMiddleware<WeatherMiddleware>();
            app.Use(async (context, next) => {
                if (context.Request.Path == "/middleware/function")
                {
                    await formatter.Format(context,
                    "Middleware Function: It is snowing in Chicago");
                }
                else
                {
                    await next();
                }
            });
            app.UseEndpoints(endpoints => {
                endpoints.MapGet("/endpoint/class", WeatherEndpoint.Endpoint);
                endpoints.MapGet("/endpoint/function", async context => {
                    await formatter.Format(context,
                    "Endpoint Function: It is sunny in LA");
                });
            });
        }
    }
}