using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffRotaMap : IEntityTypeConfiguration<StaffRota>
    {
        public void Configure(EntityTypeBuilder<StaffRota> builder)
        {
            builder.ToTable("tbl_StaffRota");
            builder.HasKey(k => k.StaffRotaId);

            #region Properties            
            builder.Property(p => p.StaffRotaId)
                .HasColumnName("StaffRotaId")
                .IsRequired();

            builder.Property(p => p.Staff)
               .HasColumnName("Staff")
               .HasMaxLength(38);

            builder.Property(p => p.ReferenceNumber)
             .HasColumnName("ReferenceNumber")
              .HasMaxLength(50);

            builder.Property(p => p.Remark)
               .HasColumnName("Remark")
               .HasMaxLength(2024);
            #endregion
        }
    }
}
