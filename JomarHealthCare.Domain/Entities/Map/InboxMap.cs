using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class InboxMap : IEntityTypeConfiguration<Inbox>
    {
        public void Configure(EntityTypeBuilder<Inbox> builder)
        {
            builder.ToTable("tbl_Inbox");
            builder.HasKey(k => k.Id);

            #region Properties

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
