using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BestInterestAssessmentMap : IEntityTypeConfiguration<BestInterestAssessment>
    {
        public void Configure(EntityTypeBuilder<BestInterestAssessment> builder)
        {
            builder.ToTable("tbl_BestInterestAssessment");
            builder.HasKey(k => k.BestId);

            #region Properties

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .HasMaxLength(256);

            builder.Property(p => p.Position)
                .HasColumnName("Position")
                .HasMaxLength(256);

            builder.Property(p => p.Signature)
               .HasColumnName("Signature")
               .HasMaxLength(1024);

            #endregion
            #region Relationship
       

            //builder.HasMany<CareIssuesTask>(p => p.CareIssuesTask)
            //    .WithOne(p => p.BestInterestAssessment)
            //    .HasForeignKey(p => p.BestId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany<HealthTask>(p => p.HealthTask)
            //    .WithOne(p => p.BestInterestAssessment)
            //    .HasForeignKey(p => p.BestId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany<HealthTask2>(p => p.HealthTask2)
            //    .WithOne(p => p.BestInterestAssessment)
            //    .HasForeignKey(p => p.BestId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany<BelieveTask>(p => p.BelieveTask)
            //    .WithOne(p => p.BestInterestAssessment)
            //    .HasForeignKey(p => p.BestId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.HasOne(p => p.Client) // navigation from BestInterestAssessment
            //   .WithOne(p => p.BestInterestAssessment) // navigation from BelieveTask
            //   .HasForeignKey<BestInterestAssessment>(p => p.ClientId) // FK in BelieveTask
            //   .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
