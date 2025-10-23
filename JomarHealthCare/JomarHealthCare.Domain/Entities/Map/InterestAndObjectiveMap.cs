using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class InterestAndObjectiveMap : IEntityTypeConfiguration<InterestAndObjective>
    {
        public void Configure(EntityTypeBuilder<InterestAndObjective> builder)
        {
            builder.ToTable("tbl_InterestAndObjective");
            builder.HasKey(k => k.GoalId);

            #region Properties
            builder.Property(p => p.GoalId)
               .HasColumnName("GoalId")
               .IsRequired();

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.CareGoal)
               .HasColumnName("CareGoal")
               .HasMaxLength(2056);

            builder.Property(p => p.Brief)
               .HasColumnName("Brief")
               .HasMaxLength(2056);
            #endregion

            #region Relationship
            // builder.HasOne(p => p.Client)
            //      .WithMany(p => p.InterestAndObjective)
            //      .HasForeignKey(p => p.CompanyId)
            //      .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.PersonalityTest)
                .WithOne(p => p.InterestAndObjective)
                .HasForeignKey(p => p.GoalId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion
        }
    }
}
