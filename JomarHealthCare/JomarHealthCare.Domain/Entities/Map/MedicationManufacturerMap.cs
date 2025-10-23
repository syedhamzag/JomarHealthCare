using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace JomarHealthCare.Domain.Entities.Map
{
    public class MedicationManufacturerMap : IEntityTypeConfiguration<MedicationManufacturer>
    {
        public void Configure(EntityTypeBuilder<MedicationManufacturer> builder)
        {
            builder.ToTable("tbl_MedicationManufacturer");
            builder.HasKey(k => k.MedicationManufacturerId);

            #region Properties

            builder.Property(p => p.Manufacturer)
               .HasColumnName("Manufacturer")
               .HasMaxLength(255);

            builder.Property(p => p.CompanyId)
               .HasColumnName("CompanyId")
               .HasMaxLength(38);
            #endregion
        }
    }
}
