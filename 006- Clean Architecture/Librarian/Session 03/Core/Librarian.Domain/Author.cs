using Librarian.Domain.Common;

namespace Librarian.Domain
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
