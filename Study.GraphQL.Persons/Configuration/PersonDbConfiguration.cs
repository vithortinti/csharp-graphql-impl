using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Study.GraphQL.Commons.Entities;

namespace Study.GraphQL.Persons.Configuration;

public class PersonDbConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("Persons");

        builder.Property(p => p.FirstName)
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(p => p.LastName)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(p => p.BirthDate)
            .IsRequired();

        builder.HasOne(p => p.Address)
            .WithMany(p => p.Persons)
            .HasForeignKey(p => p.AddressId);
    }
}