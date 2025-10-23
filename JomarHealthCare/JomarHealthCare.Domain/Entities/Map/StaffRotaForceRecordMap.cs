using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffRotaForceRecordMap : IEntityTypeConfiguration<StaffRotaForceRecord>
    {
        public void Configure(EntityTypeBuilder<StaffRotaForceRecord> builder)
        {
            builder.ToTable("tbl_StaffRotaForceRecord");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.StaffRotaPeriodId)
               .HasColumnName("StaffRotaPeriodId");

            builder.Property(p => p.forcedEntry)
               .HasColumnName("forcedEntry")
               .HasMaxLength(256);

            builder.Property(p => p.reasonExceeding)
               .HasColumnName("reasonExceeding")
               .HasMaxLength(256);

            builder.Property(p => p.Signature)
               .HasColumnName("Signature")
               .HasMaxLength(256);

            builder.Property(p => p.UpcomingplannedTask)
               .HasColumnName("UpcomingplannedTask")
               .HasMaxLength(256);
            #endregion
        }
    }
}
