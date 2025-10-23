using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class HealthAndLivingMap : IEntityTypeConfiguration<HealthAndLiving>
    {
        public void Configure(EntityTypeBuilder<HealthAndLiving> builder)
        {
            builder.ToTable("tbl_HealthAndLiving");
            builder.HasKey(k => k.HLId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.BriefHealth)
               .HasColumnName("BriefHealth")
               .HasMaxLength(2048);

            builder.Property(p => p.WakeUp)
               .HasColumnName("WakeUp")
               .HasMaxLength(2048);

            builder.Property(p => p.ObserveHealth)
               .HasColumnName("ObserveHealth")
               .HasMaxLength(2048);

            builder.Property(p => p.CareSupport)
               .HasColumnName("CareSupport")
               .HasMaxLength(2048);

            builder.Property(p => p.MovingAndHandling)
               .HasColumnName("MovingAndHandling")
               .HasMaxLength(2048);

            builder.Property(p => p.SupportToBed)
               .HasColumnName("SupportToBed")
               .HasMaxLength(2048);

            builder.Property(p => p.ContinenceNeeds)
               .HasColumnName("ContinenceNeeds")
               .HasMaxLength(2048);

            builder.Property(p => p.ContinenceSource)
               .HasColumnName("ContinenceSource")
               .HasMaxLength(2048);

            builder.Property(p => p.ConstraintDetails)
               .HasColumnName("ConstraintDetails")
               .HasMaxLength(2048);

            builder.Property(p => p.ConstraintAttachment)
               .HasColumnName("ConstraintAttachment")
               .HasMaxLength(512);

            builder.Property(p => p.SpecialCaution)
               .HasColumnName("SpecialCaution")
               .HasMaxLength(2048);
            #endregion
        }
    }
}
