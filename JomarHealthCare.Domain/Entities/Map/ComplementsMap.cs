using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ComplementsMap : IEntityTypeConfiguration<Complements>
    {
        public void Configure(EntityTypeBuilder<Complements> builder)
        {
            builder.ToTable("tbl_Complements");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Date)
               .HasColumnName("Date");

            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .HasMaxLength(512);

            builder.Property(p => p.Subject)
               .HasColumnName("Subject")
               .HasMaxLength(512);

            builder.Property(p => p.Summary)
               .HasColumnName("Summary")
               .HasMaxLength(1024);

            builder.Property(p => p.Attachment)
               .HasColumnName("Attachment")
               .HasMaxLength(512);

            builder.Property(p => p.URL)
               .HasColumnName("URL")
               .HasMaxLength(512);

            builder.Property(p => p.Remark)
               .HasColumnName("Remarks")
               .HasMaxLength(512);
            #endregion
        }
    }
}
