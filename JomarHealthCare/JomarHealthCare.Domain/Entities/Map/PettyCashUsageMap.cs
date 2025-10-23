using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PettyCashUsageMap : IEntityTypeConfiguration<PettyCashUsage>
    {
        public void Configure(EntityTypeBuilder<PettyCashUsage> builder)
        {
            builder.ToTable("tbl_PettyCashUsage");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Detail)
             .HasColumnName("Detail")
             .HasMaxLength(1024);

            builder.Property(p => p.Date)
             .HasColumnName("Date");

            builder.Property(p => p.ReceiptNo)
            .HasColumnName("ReceiptNo")
            .HasMaxLength(50);

            builder.Property(p => p.Data)
            .HasColumnName("Data");

            builder.Property(p => p.Total)
            .HasColumnName("Total");

            builder.Property(p => p.PettyCashId)
             .HasColumnName("PettyCashId");
            #endregion

            #region Relationship

            builder.HasOne(p => p.PettyCash)
             .WithMany(p => p.PettyCashUsage)
             .HasForeignKey(p => p.PettyCashId)
             .OnDelete(DeleteBehavior.Cascade);

            #endregion
        }
    }
}
