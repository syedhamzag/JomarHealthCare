using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ConsentDataMap : IEntityTypeConfiguration<ConsentData>
    {
        public void Configure(EntityTypeBuilder<ConsentData> builder)
        {
            builder.ToTable("tbl_ConsentData");
            builder.HasKey(k => k.DataId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.Signature)
              .HasColumnName("Signature")
              .HasMaxLength(512);

            builder.Property(p => p.CareSignature)
              .HasColumnName("CareSignature")
              .HasMaxLength(512);

            builder.Property(p => p.LandSignature)
              .HasColumnName("LandSignature")
              .HasMaxLength(512);

            builder.Property(p => p.FamilyResponsibity)
               .HasColumnName("FamilyResponsibity")
               .HasMaxLength(10);

            builder.Property(p => p.AdministratorProcess)
               .HasColumnName("AdministratorProcess")
               .HasMaxLength(10);

            builder.Property(p => p.OwnMedication)
               .HasColumnName("OwnMedication")
               .HasMaxLength(10);
            #endregion
        }
    }
}
