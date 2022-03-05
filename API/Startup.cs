using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using API.Middleware;
using API.Extensions;
using StackExchange.Redis;
using System.IO;
using Microsoft.Extensions.FileProviders;

namespace API
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
            services.AddControllers();
            
            //services.AddAutoMapper(typeof(MappingProfiles));
            
            services.AddDbContext<StoreContext>(x => 
            { 
                x.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
            });
                
           
            services.AddSingleton<IConnectionMultiplexer>(c => {
                var configuration = ConfigurationOptions.Parse(Configuration.GetConnectionString("Redis"), true);
                return ConnectionMultiplexer.Connect(configuration);
            });
            services.AddApplicationServices();
            //services.AddIdentityServices(Configuration);
            //services.AddSwaggerDocumentation();

            services.AddCors(opt => 
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .WithOrigins("https://localhost:4200");
                });
            });
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /*if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }*/

            app.UseMiddleware<ExceptionMiddleware>();

            //redirect to error controller
            app.UseStatusCodePagesWithReExecute("/errors/{0}");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),"Content")
                ), RequestPath ="/content"
            });
            app.UseCors("CorsPolicy");

            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseSwaggerDocumentation();            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapFallbackToController("Index", "Fallback");
            });
        }
    }
}
