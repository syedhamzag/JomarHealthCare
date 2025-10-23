using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffAlertMap : IEntityTypeConfiguration<StaffAlert>
    {
        public void Configure(EntityTypeBuilder<StaffAlert> builder)
        {
            builder.ToTable("tbl_staffalert");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.Heading)
               .HasColumnName("Heading")
               .IsRequired();

            builder.Property(p => p.IsSet)
               .HasColumnName("IsSet")
               .IsRequired();

            builder.Property(p => p.Text)
               .HasColumnName("Text")
               .IsRequired();

            builder.Property(p => p.TimeDuration)
               .HasColumnName("TimeDuration")
               .IsRequired();

            builder.Property(p => p.CreatedBy)
               .HasColumnName("CreatedBy")
               .IsRequired();

            builder.Property(p => p.CreatedDate)
              .HasColumnName("CreatedDate")
              .IsRequired();

            builder.Property(p => p.Deleted)
              .HasColumnName("Deleted")
              .IsRequired();

            #endregion
        }
    }
}
