using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map;

public class MedicationRouteMap : IEntityTypeConfiguration<MedicationRoute>
{
    public void Configure(EntityTypeBuilder<MedicationRoute> builder)
    {
        builder.ToTable("tbl_MedicationRoute");
        builder.HasKey(k => k.MedicationRoutId);

        #region Properties
        builder.Property(p => p.RouteName)
         .HasColumnName("RouteName")
         .HasMaxLength(256);

        #endregion
    }
}
