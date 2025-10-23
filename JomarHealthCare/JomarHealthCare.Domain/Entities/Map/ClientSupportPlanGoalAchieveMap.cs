using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map;

public class ClientSupportPlanGoalAchieveMap : IEntityTypeConfiguration<ClientSupportPlanGoalAchieve>
{
    public void Configure(EntityTypeBuilder<ClientSupportPlanGoalAchieve> builder)
    {
        builder.ToTable("tbl_ClientSupportPlanGoalAchieve");
        builder.HasKey(k => k.Id);

        #region Properties
        builder.Property(p => p.ClientSupportPlanGoalId)
           .HasColumnName("ClientSupportPlanGoalId");

        builder.Property(p => p.DeliveryPlan)
            .HasColumnName("DeliveryPlan");

        builder.Property(p => p.TargetDate)
            .HasColumnName("TargetDate");

        builder.Property(p => p.ReviewDate)
            .HasColumnName("ReviewDate");

        #endregion

        #region relationship

        builder.HasOne(p => p.ClientSupportPlanGoal)
         .WithMany(p => p.ClientSupportPlanGoalAchieve)
         .HasForeignKey(p => p.ClientSupportPlanGoalId)
         .OnDelete(DeleteBehavior.Cascade);

        #endregion
    }
}