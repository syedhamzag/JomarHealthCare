using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class SpecialHealthAndMedicationMap : IEntityTypeConfiguration<SpecialHealthAndMedication>
    {
        public void Configure(EntityTypeBuilder<SpecialHealthAndMedication> builder)
        {
            builder.ToTable("tbl_SpecialHealthAndMedication");
            builder.HasKey(k => k.SHMId);

            #region Properties
            builder.Property(p => p.SHMId)
               .HasColumnName("SHMId")
               .IsRequired();

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            

            #region Consent


            builder.Property(p => p.By)
               .HasColumnName("By")
               .HasMaxLength(128);

            builder.Property(p => p.PNRMedsMissing)
               .HasColumnName("PNRMedsMissing")
               .HasMaxLength(2048);


            builder.Property(p => p.MedicationStorage)
               .HasColumnName("MedicationStorage")
               .HasMaxLength(2048);

            builder.Property(p => p.PNRMedList)
               .HasColumnName("PNRMedList")
               .HasMaxLength(2048);

            builder.Property(p => p.MedKeyCode)
               .HasColumnName("MedKeyCode")
               .HasMaxLength(128);
            #endregion

            #endregion
        }
    }
}
