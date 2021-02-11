using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
// using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using MvcMusic.Data;
using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Cors.Infrastructure;

namespace MvcMusic
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
            services.AddControllersWithViews();
            services.AddDbContext<MvcMusicContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("MvcMusicContext")));

            // var corsBuilder = new CorsPolicyBuilder();
            // corsBuilder.AllowAnyHeader();
            // corsBuilder.AllowAnyMethod();
            // corsBuilder.WithOrigins("http://localhost:5000");
            // corsBuilder.WithOrigins("https://localhost:5001");
            // corsBuilder.AllowCredentials();

            // services.AddCors(options =>
            // {
            //     options.AddPolicy("SiteCorsPolicy", corsBuilder.Build());
            // });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
