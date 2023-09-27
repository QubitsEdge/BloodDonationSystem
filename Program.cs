using BloodDonationSystem.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using BloodDonationSystem.Data; // Import the namespace for your repository

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure your database context
builder.Services.AddDbContext<AppDBContext>();

// Add the repository service
builder.Services.AddScoped<IInventoryRepository, InventoryRepository>();

// Enable Swagger/OpenAPI
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "BloodDonationSystem API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
<<<<<<< HEAD
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "BloodDonationSystem API v1");
        c.RoutePrefix = "swagger";
    });
}
=======
        public static void Main(string[] args)
        {
            /*var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllerRoute(
                            name: "default",
                            pattern: "{controller=Donor}/{action=GetAll}/{id?}");
            

            app.Run();*/


            var builder = WebApplication.CreateBuilder(args);
>>>>>>> Ahmad

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
