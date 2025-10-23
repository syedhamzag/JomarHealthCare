using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ReviewMap : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("tbl_Review");
            builder.HasKey(k => k.ReviewId);

            #region Properties

            builder.Property(p => p.ClientId)
             .HasColumnName("ClientId")
             .HasMaxLength(38);

            builder.Property(p => p.CarePlanStatus)
             .HasColumnName("CarePlanStatus")
             .HasMaxLength(50);

            builder.Property(p => p.RisAssistmentStatus)
             .HasColumnName("RisAssistmentStatus")
             .HasMaxLength(50);
            #endregion
        }
    }
}
