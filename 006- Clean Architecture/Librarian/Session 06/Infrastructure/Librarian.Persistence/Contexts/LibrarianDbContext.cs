using Librarian.Domain;
using Microsoft.EntityFrameworkCore;

namespace Librarian.Persistence.Contexts
{
    public class LibrarianDbContext : DbContext
    {
        public LibrarianDbContext(DbContextOptions<LibrarianDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
