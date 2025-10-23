using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CapacityIndicatorMap : IEntityTypeConfiguration<CapacityIndicator>
    {
        public void Configure(EntityTypeBuilder<CapacityIndicator> builder)
        {
            builder.ToTable("tbl_CapacityIndicator");
            builder.HasKey(k => k.CapacityIndicatorId);

            #region Properties

            builder.Property(p => p.CapacityIndicatorId)
               .HasColumnName("CapacityIndicatorId")
               .IsRequired();

            builder.Property(p => p.BaseRecordId)
                .HasColumnName("BaseRecordId")
                .IsRequired();

            builder.Property(p => p.CapacityId)
               .HasColumnName("CapacityId")
               .IsRequired();

            #endregion
        }
    }
}
