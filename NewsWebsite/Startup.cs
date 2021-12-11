using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Coravel;
using Coravel.Scheduling.Schedule.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NewsWebsite.Data;
using NewsWebsite.IocConfig;
using NewsWebsite.Services;
using NewsWebsite.ViewModels.Settings;

namespace NewsWebsite
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IServiceProvider Services { get; }
        public Startup(IConfiguration configuration, IServiceProvider services)
        {
            Configuration = configuration;
            Services = services;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<SiteSettings>(Configuration.GetSection(nameof(SiteSettings)));
            services.AddDbContext<NewsDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlServer")));
            services.AddCustomServices();
            services.AddCustomIdentityServices();
            services.AddAutoMapper();
            services.AddScheduler();
            services.ConfigureWritable<SiteSettings>(Configuration.GetSection("SiteSettings"));
            services.ConfigureApplicationCookie(options =>
            {
                //options.LoginPath = "/Account/SignIn";
                options.AccessDeniedPath = "/Admin/Manage/AccessDenied";
            });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseCustomIdentityServices();

            var provider = app.ApplicationServices;

            provider.UseScheduler(scheduler =>
            {
                //scheduler.Schedule<SendWeeklyNewsletter>().EveryMinute();
                scheduler.Schedule<SendWeeklyNewsletter>().Cron("29 20 * * 5"); //UTC Time
                //scheduler.Schedule<SendWeeklyNewsletter>().Cron("14 15 * * 0"); //UTC Time
            }).LogScheduledTaskProgress(Services.GetService<ILogger<IScheduler>>());

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                routes.MapRoute(
                 name: "default",
                 template: "{controller=Home}/{action=Index}/{id?}"
               );

            });
        }
    }
}
