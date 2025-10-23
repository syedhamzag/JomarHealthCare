using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class EmailMessageMap : IEntityTypeConfiguration<EmailMessage>
    {
        public void Configure(EntityTypeBuilder<EmailMessage> builder)
        {
            builder.ToTable("tbl_EmailMessage");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.SendDate)
               .HasColumnName("SendDate");

            builder.Property(p => p.Subject)
               .HasColumnName("Subject")
               .HasMaxLength(512);

            builder.Property(p => p.Message)
               .HasColumnName("Message");

            builder.Property(p => p.Category)
               .HasColumnName("Category");

            builder.Property(p => p.CompanyId)
               .HasColumnName("CompanyId")
               .HasMaxLength(512);
            #endregion
        }
    }
}
