using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffPerformanceMap : IEntityTypeConfiguration<StaffPerformance>
    {
        public void Configure(EntityTypeBuilder<StaffPerformance> builder)
        {
            builder.ToTable("tbl_StaffPerformance");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.StaffId)
             .HasColumnName("StaffId");

            builder.Property(p => p.Data)
                .HasColumnName("Data");

            builder.Property(p => p.TotalObtain)
                .HasColumnName("TotalObtain");

            builder.Property(p => p.Expectation)
            .HasColumnName("Expectation");

            builder.Property(p => p.Rating)
            .HasColumnName("Rating")
            .HasMaxLength(100);

            builder.Property(p => p.CreatedBy)
            .HasColumnName("CreatedBy")
            .HasMaxLength(450);

            builder.Property(p => p.Remarks)
            .HasColumnName("Remarks")
            .HasMaxLength(450);

            builder.Property(p => p.PositionId)
            .HasColumnName("PositionId");

            builder.Property(p => p.PerformanceSummaryId)
            .HasColumnName("PerformanceSummaryId");

            builder.Property(p => p.CompanyId)
            .HasColumnName("ClientId");
            #endregion

            #region Relationship

            builder.HasOne(p => p.PerformanceSummary)
             .WithMany(p => p.StaffPerformance)
             .HasForeignKey(p => p.PerformanceSummaryId)
             .OnDelete(DeleteBehavior.Cascade);

            #endregion
        }
    }
}
