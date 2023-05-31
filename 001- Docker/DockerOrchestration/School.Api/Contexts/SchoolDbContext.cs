using School.Api.Models;
using Microsoft.EntityFrameworkCore;
using School.Domain.Models;

namespace School.Api.Contexts
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }

        public void SeedData()
        {
            if (this.Database.EnsureCreated())
            {
                this.Students.AddRange(
                  new Student()
                  {
                      FirstName = "Foad",
                      LastName = "Alavi",
                      BirthDay = new DateTime(2023, 5, 24),
                      Address = "Address 1"
                  },
                  new Student()
                  {
                      FirstName = "Ned",
                      LastName = "Stark",
                      BirthDay = new DateTime(1960, 02, 05),
                      Address = "3271 Auer Parks, South Dedricburgh, Romania"
                  },
                  new Student()
                  {
                      FirstName = "Aria",
                      LastName = "Stark",
                      BirthDay = new DateTime(2008, 09, 15),
                      Address = "032 Greenholt Light, Dietrichton, Peru"
                  });
                SaveChanges();
            }
        }

        public DbSet<Student> Students { get; set; }
    }
}
