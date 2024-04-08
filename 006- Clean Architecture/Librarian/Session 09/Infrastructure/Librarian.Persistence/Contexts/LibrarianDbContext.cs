using Librarian.Domain;
using Microsoft.EntityFrameworkCore;

namespace Librarian.Persistence.Contexts
{
    public class LibrarianDbContext : DbContext
    {
        public LibrarianDbContext(DbContextOptions<LibrarianDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LibrarianDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
