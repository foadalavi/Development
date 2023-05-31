using School.Ui.Services;

namespace School.Ui
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddHttpClient("ApiClient", config =>
            {
                config.BaseAddress = new Uri(builder.Configuration.GetSection("ServersBaseUrl:Api").Value);
            });
            Console.WriteLine("\n\n                  **********************************************************************");
            Console.WriteLine(builder.Configuration.GetSection("ServersBaseUrl:Api").Value);
            Console.WriteLine("                  **********************************************************************\n\n");
            builder.Services.AddTransient<ISchoolService, SchoolService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}