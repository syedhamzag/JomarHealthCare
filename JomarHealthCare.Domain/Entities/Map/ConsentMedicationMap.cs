using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ConsentMedicationMap : IEntityTypeConfiguration<ConsentMedication>
    {
        public void Configure(EntityTypeBuilder<ConsentMedication> builder)
        {
            builder.ToTable("tbl_ConsentMedication");
            builder.HasKey(k => k.ConsentMedicationId);

            #region Properties

            builder.Property(p => p.OwnMedication)
               .HasColumnName("OwnMedication")
               .HasMaxLength(10);

            builder.Property(p => p.PersonalDetailId)
               .HasColumnName("PersonalDetailId")
               .IsRequired();

            builder.Property(p => p.FamilyResponsibity)
               .HasColumnName("FamilyResponsibity")
               .HasMaxLength(10);

            builder.Property(p => p.AdministratorProcess)
               .HasColumnName("AdministratorProcess")
               .HasMaxLength(10);

            #endregion
        }
    }
}
