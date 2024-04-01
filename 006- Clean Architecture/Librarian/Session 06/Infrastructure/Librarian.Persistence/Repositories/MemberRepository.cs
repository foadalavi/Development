using Librarian.Application.Contracts.Persistence;
using Librarian.Domain;
using Librarian.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Librarian.Persistence.Repositories
{
    public class MemberRepository : GenericRepository<Domain.Member>, IMemberRepository
    {
        public MemberRepository(LibrarianDbContext context) : base(context)
        {
        }

        public async Task<bool> IsMemberUnique(Member entity)
        {
            return await _dbSet.AnyAsync(t =>
                t.FirstName == entity.FirstName &&
                t.LastName == entity.LastName &&
                t.Email == entity.Email &&
                t.DateOfBirth == entity.DateOfBirth
                ) == false;
        }
    }
}
