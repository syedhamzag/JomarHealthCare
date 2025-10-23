using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class HealthConditionMap : IEntityTypeConfiguration<HealthCondition>
    {
        public void Configure(EntityTypeBuilder<HealthCondition> builder)
        {
            builder.ToTable("tbl_HealthCondition");
            builder.HasKey(k => k.HCId);

            #region Properties
            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .IsRequired();

            builder.Property(p => p.Description)
               .HasColumnName("Description")
               .IsRequired();

            builder.Property(p => p.Condition)
            .HasColumnName("Condition");

            builder.Property(p => p.CausesAndTrigger)
            .HasColumnName("CausesAndTrigger");

            builder.Property(p => p.Symptoms)
            .HasColumnName("Symptoms");

            builder.Property(p => p.ClientManagingWithCondition)
            .HasColumnName("ClientManagingWithCondition");

            builder.Property(p => p.RiskToClient)
            .HasColumnName("RiskToClient");

            builder.Property(p => p.RiskToStaff)
            .HasColumnName("RiskToStaff");

            builder.Property(p => p.ActionRequiredToStaff)
           .HasColumnName("ActionRequiredToStaff");
            
            builder.Property(p => p.EscalationsApproach)
           .HasColumnName("EscalationsApproach");

            builder.Property(p => p.EscalationsApproach)
            .HasColumnName("Image");

            builder.Property(p => p.CreatedBy)
              .HasColumnName("CreatedBy")
              .HasMaxLength(450);
            #endregion
        }
    }
}
