using Librarian.Application.Contracts.Persistence;
using Librarian.Persistence.Contexts;

namespace Librarian.Persistence.Repositories
{
    public class MemberRepository : GenericRepository<Domain.Member>, IMemberRepository
    {
        public MemberRepository(LibrarianDbContext context) : base(context)
        {
        }
    }
}
