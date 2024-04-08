using Librarian.Domain;

namespace Librarian.Application.Contracts.Persistence
{
    public interface IMemberRepository : IGenericRepository<Domain.Member>
    {
        Task<bool> IsMemberUnique(Member entiry);
    }
}
