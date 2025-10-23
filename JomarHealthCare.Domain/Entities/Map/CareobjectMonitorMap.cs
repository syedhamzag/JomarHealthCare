using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CareobjectMonitorMap : IEntityTypeConfiguration<CareobjectMonitor>
    {
        public void Configure(EntityTypeBuilder<CareobjectMonitor> builder)
        {
            builder.ToTable("tbl_CareobjectMonitor");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.CompanyId)
               .HasColumnName("ClientId");

            builder.Property(p => p.Month)
               .HasColumnName("Month");

            builder.Property(p => p.Year)
               .HasColumnName("Year");

            builder.Property(p => p.Day)
               .HasColumnName("Day");

            builder.Property(p => p.DateOfCare)
               .HasColumnName("DateOfCare");
            #endregion
        }
    }
}
