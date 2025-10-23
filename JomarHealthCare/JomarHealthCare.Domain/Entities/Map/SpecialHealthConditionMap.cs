using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class SpecialHealthConditionMap : IEntityTypeConfiguration<SpecialHealthCondition>
    {
        public void Configure(EntityTypeBuilder<SpecialHealthCondition> builder)
        {
            builder.ToTable("tbl_SpecialHealthCondition");
            builder.HasKey(k => k.HealthCondId);

            #region Properties

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.ClientAction)
               .HasColumnName("ClientAction")
               .HasMaxLength(1024);

            builder.Property(p => p.ClinicRecommendation)
               .HasColumnName("ClinicRecommendation")
               .HasMaxLength(2048);

            builder.Property(p => p.ConditionName)
               .HasColumnName("ConditionName")
               .HasMaxLength(2048);

            builder.Property(p => p.FeelingAfterIncident)
               .HasColumnName("FeelingAfterIncident")
               .HasMaxLength(2048);

            builder.Property(p => p.FeelingBeforeIncident)
               .HasColumnName("FeelingBeforeIncident")
               .HasMaxLength(2048);

            builder.Property(p => p.Frequency)
               .HasColumnName("Frequency")
               .HasMaxLength(2048);

            builder.Property(p => p.LifestyleSupport)
               .HasColumnName("LifestyleSupport")
               .HasMaxLength(2048);

            builder.Property(p => p.LivingActivities)
               .HasColumnName("LivingActivities")
               .HasMaxLength(2048);

            builder.Property(p => p.PlanningHealthCondition)
               .HasColumnName("PlanningHealthCondition")
               .HasMaxLength(2048);

            builder.Property(p => p.SourceInformation)
               .HasColumnName("SourceInformation")
               .HasMaxLength(1024);

            builder.Property(p => p.Trigger)
               .HasColumnName("Trigger")
               .HasMaxLength(512);
            #endregion
        }
    }
}
