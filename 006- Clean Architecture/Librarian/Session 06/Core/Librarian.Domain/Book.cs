using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librarian.Domain.Common;

namespace Librarian.Domain
{
    public class Book : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public Author Author { get; set; } = new Author();
        public int AuthorId { get; set; }

        public DateTime PublishDate { get; set; }
        public int Qty { get; set; }
    }
}
