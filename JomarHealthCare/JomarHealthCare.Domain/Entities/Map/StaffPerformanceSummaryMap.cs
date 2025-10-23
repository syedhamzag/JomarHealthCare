using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffPerformanceSummaryMap : IEntityTypeConfiguration<StaffPerformanceSummary>
    {
        public void Configure(EntityTypeBuilder<StaffPerformanceSummary> builder)
        {
            builder.ToTable("tbl_StaffPerformanceSummary");
            builder.HasKey(k => k.SummaryId);

            #region Properties
            builder.Property(p => p.StartDate)
             .HasColumnName("StartDate")
             .HasMaxLength(20);

            builder.Property(p => p.StopDate)
                .HasColumnName("StopDate") 
                .HasMaxLength(20);

            builder.Property(p => p.WithoutJob)
                .HasColumnName("WithoutJob");

            builder.Property(p => p.NoOfPerformance)
            .HasColumnName("NoOfPerformance");

            builder.Property(p => p.Feedback)
            .HasColumnName("Feedback")
            .HasMaxLength(1024);

            builder.Property(p => p.CreatedBy)
            .HasColumnName("CreatedBy")
            .HasMaxLength(450);

            builder.Property(p => p.IsClientSummary)
            .HasColumnName("IsClientSummary");
            #endregion
        }

    }
}
