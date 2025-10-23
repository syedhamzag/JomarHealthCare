using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class HomeRiskAssessmentMap : IEntityTypeConfiguration<HomeRiskAssessment>
    {
        public void Configure(EntityTypeBuilder<HomeRiskAssessment> builder)
        {
            builder.ToTable("tbl_HomeRiskAssessment");
            builder.HasKey(k => k.HomeRiskAssessmentId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .IsRequired();

            builder.Property(p => p.HeadingId)
               .HasColumnName("HeadingId");
            #endregion

            #region Relationship
            
            builder.HasMany<HomeRiskAssessmentTask>(p => p.HomeRiskAssessmentTask)
                .WithOne(p => p.HomeRiskAssessment)
                .HasForeignKey(p => p.HomeRiskAssessmentId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
