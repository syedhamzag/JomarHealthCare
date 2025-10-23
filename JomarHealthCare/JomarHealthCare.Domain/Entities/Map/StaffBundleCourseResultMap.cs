using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffBundleCourseResultMap : IEntityTypeConfiguration<StaffBundleCourseResult>
    {
        public void Configure(EntityTypeBuilder<StaffBundleCourseResult> builder)
        {
            builder.ToTable("tbl_StaffBundleCourseResult");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.BundleId)
             .HasColumnName("BundleId");

            builder.Property(p => p.TrainingCourseId)
             .HasColumnName("TrainingCourseId");

            builder.Property(p => p.StaffId)
                .HasColumnName("StaffId");

            builder.Property(p => p.IsEligibleForTest)
                .HasColumnName("IsEligibleForTest"); 
            
            builder.Property(p => p.ObtainMarks)
                .HasColumnName("ObtainMarks");

            builder.Property(p => p.Status)
            .HasColumnName("Status")
            .HasMaxLength(50);
            #endregion


        }
    }
}
