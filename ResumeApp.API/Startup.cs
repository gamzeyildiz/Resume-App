using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ResumeApp.Business.Abstract;
using ResumeApp.Business.Concrete;
using ResumeApp.DataAccess;
using ResumeApp.DataAccess.Abstact;
using ResumeApp.DataAccess.Concrete;
using Serilog.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApp.API
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
            services.AddDbContext<ResumeDbContext>(options =>
                options.UseSqlServer(
                    Configuration["DefaultConnection:ConnectionString"]
                ));
            services.AddControllers();
            services.AddSingleton<IBioService, BioManager>();
            services.AddSingleton<ICertificateService, CertificateManager>();
            services.AddSingleton<IExperienceService, ExperienceManager>();
            services.AddSingleton<IProjectService, ProjectManager>();
            services.AddSingleton<IResumeService, ResumeManager>();
            services.AddSingleton<IBioRepository, BioRepository>();
            services.AddSingleton<ICertificateRepository, CertificateRepository>();
            services.AddSingleton<IExperienceRepository, ExperienceRepository>();
            services.AddSingleton<IProjectRepository, ProjectRepository>();
            services.AddSingleton<IResumeRepository, ResumeRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //middleware
            app.Use(async (httpContext, next) =>
            {
                var username = httpContext.User.Identity.IsAuthenticated ? httpContext.User.Identity.Name : "anonymous";

                LogContext.PushProperty("UserName", username);

                await next.Invoke();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
