using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class HistoryOfFallMap : IEntityTypeConfiguration<HistoryOfFall>
    {
        public void Configure(EntityTypeBuilder<HistoryOfFall> builder)
        {
            builder.ToTable("tbl_HistoryOfFall");
            builder.HasKey(k => k.HistoryId);

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.Details)
               .HasColumnName("Details")
               .HasMaxLength(2048);

            builder.Property(p => p.Cause)
               .HasColumnName("Cause")
               .HasMaxLength(2048);

            builder.Property(p => p.Prevention)
               .HasColumnName("Prevention")
               .HasMaxLength(2048);
            
            builder.Property(p => p.DetailofRisk)
               .HasColumnName("DetailofRisk")
               .HasMaxLength(2048);

            builder.Property(p => p.CauseAndTriger)
               .HasColumnName("CauseAndTriger")
               .HasMaxLength(2048);

            builder.Property(p => p.HowToControl)
               .HasColumnName("HowToControl")
               .HasMaxLength(2048);

            builder.Property(p => p.Escallation)
               .HasColumnName("Escallation")
               .HasMaxLength(256);

        }
    }
}
