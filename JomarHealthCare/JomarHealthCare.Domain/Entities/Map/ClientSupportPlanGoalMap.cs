using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map;

public class ClientSupportPlanGoalMap : IEntityTypeConfiguration<ClientSupportPlanGoal>
{
    public void Configure(EntityTypeBuilder<ClientSupportPlanGoal> builder)
    {
        builder.ToTable("tbl_ClientSupportPlanGoal");
        builder.HasKey(k => k.Id);

        #region Properties
        builder.Property(p => p.ClientSupportPlanId)
           .HasColumnName("ClientSupportPlanId");

        builder.Property(p => p.Goal)
            .HasColumnName("Goal");

        builder.Property(p => p.Important)
            .HasColumnName("Important");

        builder.Property(p => p.Help)
            .HasColumnName("Help");

        builder.Property(p => p.Success)
            .HasColumnName("Success");
        #endregion

        #region relationship

        builder.HasOne(p => p.ClientSupportPlan)
         .WithMany(p => p.ClientSupportPlanGoal)
         .HasForeignKey(p => p.ClientSupportPlanId)
         .OnDelete(DeleteBehavior.Cascade);

        #endregion
    }
}
