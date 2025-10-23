using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class EquipmentAssessmentDataMap : IEntityTypeConfiguration<EquipmentAssessmentData>
    {
        public void Configure(EntityTypeBuilder<EquipmentAssessmentData> builder)
        {
            builder.ToTable("tbl_EquipmentAssessmentData");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.EquipmentAssessmentId)
               .HasColumnName("EquipmentAssessmentId");

            builder.Property(p => p.URL)
            .HasColumnName("URL")
            .HasMaxLength(1024);

            builder.Property(p => p.HowToUse)
            .HasColumnName("HowToUse")
            .HasMaxLength(4000);

            builder.Property(p => p.ClientRisk)
            .HasColumnName("ClientRisk")
            .HasMaxLength(4000);

            builder.Property(p => p.StaffRisk)
            .HasColumnName("StaffRisk")
            .HasMaxLength(4000);

            builder.Property(p => p.Image)
            .HasColumnName("Image")
            .HasMaxLength(1024);

            #endregion

        }
    }
}
