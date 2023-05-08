using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Task20
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseHttpsRedirection();

            app.UseMvc(
                r =>
                {
                    r.MapRoute(
                        name: "default",
                        template:"{controller=Home}/{action=Index}/{id?}"
                    );
                });
        }
    }
}
