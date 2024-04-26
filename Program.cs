using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Energy_Insights.Data;
namespace Energy_Insights
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Energy_InsightsContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Energy_InsightsContext") ?? throw new InvalidOperationException("Connection string 'Energy_InsightsContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
