using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffPerformanceHeadingMap : IEntityTypeConfiguration<StaffPerformanceHeading>
    {
        public void Configure(EntityTypeBuilder<StaffPerformanceHeading> builder)
        {
            builder.ToTable("tbl_StaffPerformanceHeading");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Name)
             .HasColumnName("Name")
             .HasMaxLength(250);

            builder.Property(p => p.JobPositionId)
             .HasColumnName("JobPositionId");

            builder.Property(p => p.CreatedBy)
            .HasColumnName("CreatedBy")
            .HasMaxLength(450);

            builder.Property(p => p.IsClientHeading)
            .HasColumnName("IsClientHeading");

            builder.HasOne(p => p.JobPosition)
             .WithMany(p => p.StaffPerformanceHeading)
             .HasForeignKey(p => p.JobPositionId)
             .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}
