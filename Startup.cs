using BloodDonationSystem.Model;
using BloodDonationSystem.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace BloodDonationSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("BloodDonationConnection"));
            });
            services.AddScoped<IDonorRepository, DonorRepository>();
            services.AddScoped<IInventoryRepository, InventoryRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddControllers();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                    builder => builder.WithOrigins("http://localhost:4200") // Angular's default development server
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            });
            services.AddSwaggerGen(swag =>
            {
                swag.SwaggerDoc("V1", new OpenApiInfo { Title = "Blood Donating System", Version = "V1" });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("AllowOrigin");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {

            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(swag =>
            {
                swag.SwaggerEndpoint("/swagger/V1/swagger.json", "Blood Donating API V1");
                swag.RoutePrefix = "swagger";
            });
        }
    }
}
