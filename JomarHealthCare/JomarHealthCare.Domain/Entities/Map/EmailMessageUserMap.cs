using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class EmailMessageUserMap : IEntityTypeConfiguration<EmailMessageUser>
    {
        public void Configure(EntityTypeBuilder<EmailMessageUser> builder)
        {
            builder.ToTable("tbl_EmailMessageUser");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.EmailMessageId)
               .HasColumnName("EmailMessageId");

            builder.Property(p => p.StaffId)
               .HasColumnName("StaffId");

            builder.Property(p => p.IncludeCC)
               .HasColumnName("IncludeCC")
               .HasMaxLength(200);

            #endregion

            #region Relationship

            builder.HasOne(p => p.EmailMessage)
                 .WithMany(p => p.EmailMessageUser)
                 .HasForeignKey(p => p.EmailMessageId)
                 .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
