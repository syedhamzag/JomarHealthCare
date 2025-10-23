using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class AppMessageMap : IEntityTypeConfiguration<AppMessage>
    {
        public void Configure(EntityTypeBuilder<AppMessage> builder)
        {
            builder.ToTable("tbl_AppMessage");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Date)
               .HasColumnName("Date");

            builder.Property(p => p.Subject)
               .HasColumnName("Subject")
               .HasMaxLength(512);

            builder.Property(p => p.Message)
               .HasColumnName("Message")
               .HasMaxLength(512);

            builder.Property(p => p.ToWhom)
               .HasColumnName("ToWhom");

            builder.Property(p => p.FromDate)
               .HasColumnName("FromDate");

            builder.Property(p => p.ToDate)
               .HasColumnName("ToDate");

            #endregion
        }
    }
}
