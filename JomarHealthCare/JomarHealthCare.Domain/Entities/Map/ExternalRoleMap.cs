using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ExternalRoleMap : IEntityTypeConfiguration<ExternalRole>
    {
        public void Configure(EntityTypeBuilder<ExternalRole> builder)
        {
            builder.ToTable("tbl_ExternalRole");
            builder.HasKey(p => p.ExternalId);


            builder.Property(p => p.UserId)
                .HasColumnName("UserId");

            builder.Property(p => p.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.Telephone)
           .HasColumnName("Telephone")
           .HasMaxLength(100)
           .IsRequired();

            builder.Property(p => p.Password)
           .HasColumnName("Password")
           .HasMaxLength(255)
           .IsRequired();
        }
    }
}
