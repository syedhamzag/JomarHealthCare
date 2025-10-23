using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class EquipmentAssessmentMap : IEntityTypeConfiguration<EquipmentAssessment>
    {
        public void Configure(EntityTypeBuilder<EquipmentAssessment> builder)
        {
            builder.ToTable("tbl_EquipmentAssessment");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.EquipmentName)
            .HasColumnName("EquipmentName")
            .HasMaxLength(150);

            builder.Property(p => p.EquipmentLocation)
            .HasColumnName("EquipmentLocation")
            .HasMaxLength(150);

            builder.Property(p => p.EquipmentStatus)
            .HasColumnName("EquipmentStatus")
            .HasMaxLength(150);

            builder.Property(p => p.Url)
            .HasColumnName("Url")
            .HasMaxLength(512);

            builder.Property(p => p.ExpiryDate)
            .HasColumnName("ExpiryDate");

            builder.Property(p => p.Training)
            .HasColumnName("Training")
            .HasMaxLength(150);

            builder.Property(p => p.HowToUse)
            .HasColumnName("HowToUse");

            builder.Property(p => p.RiskOfStaff)
            .HasColumnName("RiskOfStaff");

            builder.Property(p => p.RiskOfClient)
            .HasColumnName("RiskOfClient");

            builder.Property(p => p.RiskControl)
            .HasColumnName("RiskControl");

            builder.Property(p => p.Environment)
            .HasColumnName("Environment");

            builder.Property(p => p.Escalation)
            .HasColumnName("Escalation");

            builder.Property(p => p.Escalation)
            .HasColumnName("Attachment")
            .HasMaxLength(512);
            #endregion


            #region Relation
            builder.HasOne(p => p.Client)
                 .WithMany(p => p.EquipmentAssessment)
                 .HasForeignKey(p => p.ClientId);
            #endregion

        }
    }
}
