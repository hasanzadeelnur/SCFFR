using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Prometheus;
using TCYDMWebServices.Data;
using TCYDMWebServices.DTO;
using TCYDMWebServices.Models;
using TCYDMWebServices.Repositories.Abstracts;
using TCYDMWebServices.Repositories.Repos;

namespace TCYDMWebServices
{
    public class Startup
    {
        private readonly IHttpContextAccessor httpContext;
        public Startup(IConfiguration configuration)
        {
            httpContext = new HttpContextAccessor();
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddSwaggerDocument();
            services.TryAddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ITransactions<UserDTO>,UserRepos>();
            services.AddTransient<ITransactions<OnlineQueryDTO>, OnlineQueryRepos>();
            services.AddTransient<ITransactions<WhatWeDoDTO>, WhatWeDoRepos>();
            services.AddTransient<ITransactions<ServiceInfo>, ServiceInfoRepos>();
            services.AddTransient<ITransactions<WhoWeAreDTO>, WhoWeAreRepos>();
            services.AddTransient<ITransactions<ContactUsDTO>, ContactUsRepos>();
            services.AddTransient<ITransactions<OurServicesDTO>, OurServicesRepos>();
            //services.AddDbContext<DatabaseContext>(a => a.UseSqlServer(Configuration.GetConnectionString("DatabaseContext")));
            services.AddDbContext<DatabaseContext>(a => a.UseMySql(Configuration.GetConnectionString("MySqlContext")));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
             .AddJwtBearer(options =>
             {
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidateIssuerSigningKey = true,
                     ValidIssuer = Configuration["Jwt:Issuer"],
                     ValidAudience = Configuration["Jwt:Issuer"],
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                 };
             });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseOpenApi();

            app.UseSwaggerUi3();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseMetricServer();

            app.UseHttpMetrics();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
