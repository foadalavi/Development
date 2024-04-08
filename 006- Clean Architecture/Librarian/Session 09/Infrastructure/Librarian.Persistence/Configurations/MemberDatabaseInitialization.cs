using Librarian.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Persistence.Configurations
{
    public class MemberDatabaseInitialization : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasData(
                [
                    new Member
                    {
                        Id = 1,
                        FirstName = "John",
                        LastName = "Doe",
                        Email = "JohnDoe@teleworm.us",
                        DateOfBirth = new DateTime(1988,5,3),
                        Phone ="06123",
                        PostalCode ="2262 AD",
                        CreationDate = DateTime.Now,
                        ModificationDate = DateTime.Now,
                    },
                    new Member
                    {
                        Id = 2,
                        FirstName = "Sara",
                        LastName = "Smith",
                        Email = "SaraSmith@armyspy.com",
                        DateOfBirth = new DateTime(1976, 03, 15),
                        Phone = "06987",
                        PostalCode = "2319 PJ",
                        CreationDate = DateTime.Now,
                        ModificationDate = DateTime.Now,
                    },
                ]);

            builder.Property(q => q.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(q => q.LastName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(q => q.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(q => q.Phone)
                .IsRequired()
                .HasMaxLength(12);
            builder.Property(q => q.PostalCode)
                .IsRequired()
                .HasMaxLength(7);
            builder.Property(q => q.DateOfBirth)
                .IsRequired();


            builder.Property(q => q.Id)
                .IsRequired()
                .UseIdentityColumn();
            builder.Property(q => q.CreationDate)
                .IsRequired();
            builder.Property(q => q.ModificationDate)
                .IsRequired();
            builder.Property(q => q.CreatedBy)
                .IsRequired();
            builder.Property(q => q.ModifiedBy)
                .IsRequired();
        }
    }
}
