namespace Librarian.Domain.Common
{
    public class BaseEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;



        public int Id { get; set; }
        public DateTime ModificationDate { get; set; } = DateTime.Now;
        public int ModifiedBy { get; set; }
    }
}