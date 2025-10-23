using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PettyCashMap : IEntityTypeConfiguration<PettyCash>
    {
        public void Configure(EntityTypeBuilder<PettyCash> builder)
        {
            builder.ToTable("tbl_PettyCash");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Detail)
             .HasColumnName("Detail")
             .HasMaxLength(1024);

            builder.Property(p => p.Date)
             .HasColumnName("Date");

            builder.Property(p => p.StaffId)
            .HasColumnName("StaffId");
            
            builder.Property(p => p.MethodId)
            .HasColumnName("MethodId");
            
            builder.Property(p => p.Amount)
            .HasColumnName("Ammount");

            builder.Property(p => p.CompanyId)
             .HasColumnName("CreatedBy")
             .HasMaxLength(450);
            #endregion
        }
    }
}
