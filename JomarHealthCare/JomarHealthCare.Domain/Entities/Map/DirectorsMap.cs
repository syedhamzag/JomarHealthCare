using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class DirectorsMap : IEntityTypeConfiguration<Directors>
    {
        public void Configure(EntityTypeBuilder<Directors> builder)
        {

            builder.ToTable("tbl_Directors");
            builder.HasKey(p => p.Id);

            #region Properties

            builder.Property(p => p.FirstName)
             .HasColumnName("FirstName")
             .HasMaxLength(128);

            builder.Property(p => p.MiddleName)
             .HasColumnName("MiddleName")
             .HasMaxLength(128);

            builder.Property(p => p.lastName)
             .HasColumnName("lastName")
             .HasMaxLength(128);

            builder.Property(p => p.Address)
                 .HasColumnName("Address")
                 .HasMaxLength(512);

            builder.Property(p => p.Telephone)
                .HasColumnName("Telephone")
                .HasMaxLength(30);

            builder.Property(p => p.PostCode)
                .HasColumnName("PostCode")
                .HasMaxLength(30);

            builder.Property(p => p.Email)
                 .HasColumnName("Email")
                 .HasMaxLength(256);

            builder.Property(p => p.UserId)
                 .HasColumnName("UserId")
                 .HasMaxLength(450);

            builder.Property(p => p.CreatedBy)
                 .HasColumnName("CreatedBy")
                 .HasMaxLength(450);

            builder.Property(p => p.Password)
           .HasColumnName("Password")
           .HasMaxLength(255);

            #endregion
        }
    }
}
