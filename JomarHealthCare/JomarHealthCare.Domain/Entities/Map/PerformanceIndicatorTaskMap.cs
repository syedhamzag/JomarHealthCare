using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PerformanceIndicatorTaskMap : IEntityTypeConfiguration<PerformanceIndicatorTask>
    {
        public void Configure(EntityTypeBuilder<PerformanceIndicatorTask> builder)
        {
            builder.ToTable("tbl_PerformanceIndicatorTask");
            builder.HasKey(k => k.PerformanceIndicatorTaskId);

            #region Properties
            builder.Property(p => p.PerformanceIndicatorId)
               .HasColumnName("StaffCompetenceTestId")
               .IsRequired();

            builder.Property(p => p.Title)
               .HasColumnName("Title")
               .IsRequired();

            builder.Property(p => p.Score)
               .HasColumnName("Score")
               .IsRequired();
            #endregion
        }
    }
}
