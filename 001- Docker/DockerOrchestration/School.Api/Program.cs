using School.Api.Contexts;
using School.Api.Services;
using Microsoft.EntityFrameworkCore;

namespace DatabaseApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<SchoolDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                Console.WriteLine("\n\n                  **********************************************************************");
                Console.WriteLine(builder.Configuration.GetConnectionString("DefaultConnection"));
                Console.WriteLine("                  **********************************************************************\n\n");
            });
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(configuration =>
                {
                    configuration.AllowAnyMethod();
                    configuration.AllowAnyOrigin();
                });
            });
            builder.Services.AddTransient<IStudentService, StudentService>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors();

            app.UseAuthorization();

            app.MapControllers();

            using (var scope = app.Services.CreateScope())
            {
                var cntx = scope.ServiceProvider.GetRequiredService<SchoolDbContext>();
                cntx.SeedData();
            }

            app.Run();
        }
    }
}