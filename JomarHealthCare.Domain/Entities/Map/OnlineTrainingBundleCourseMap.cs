using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class OnlineTrainingBundleCourseMap : IEntityTypeConfiguration<OnlineTrainingBundleCourse>
    {
        public void Configure(EntityTypeBuilder<OnlineTrainingBundleCourse> builder)
        {
            builder.ToTable("tbl_OnlineTrainingBundleCourse");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.OnlineTrainingBundleId)
             .HasColumnName("OnlineTrainingBundleId");

            builder.Property(p => p.OnlineTrainingId)
            .HasColumnName("OnlineTraningId");
            #endregion

            #region Relationship
            builder.HasOne(p => p.OnlineTrainingBundle)
             .WithMany(p => p.OnlineTrainingBundleCourse)
             .HasForeignKey(p => p.OnlineTrainingBundleId)
             .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
