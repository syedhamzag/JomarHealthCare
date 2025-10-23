using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CapacityMap : IEntityTypeConfiguration<Capacity>
    {
        public void Configure(EntityTypeBuilder<Capacity> builder)
        {
            builder.ToTable("tbl_Capacity");
            builder.HasKey(k => k.CapacityId);

            #region Properties

            builder.Property(p => p.CapacityId)
               .HasColumnName("CapacityId")
               .IsRequired();

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.Indicators)
             .HasColumnName("Indicators")
             .HasMaxLength(100);

            #endregion
        }
    }
}
