using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffCompetenceTestMap : IEntityTypeConfiguration<StaffCompetenceTest>
    {
        public void Configure(EntityTypeBuilder<StaffCompetenceTest> builder)
        {
            builder.ToTable("tbl_StaffCompetenceTest");
            builder.HasKey(k => k.StaffCompetenceTestId);

            #region Properties
            builder.Property(p => p.StaffPersonalInfoId)
               .HasColumnName("StaffPersonalInfoId")
               .IsRequired();

            builder.Property(p => p.Heading)
               .HasColumnName("Heading")
               .IsRequired();

            #endregion

            #region Relationship
            builder.HasOne(p => p.StaffPersonalInfo)
                 .WithMany(p => p.StaffCompetenceTest)
                 .HasForeignKey(p => p.StaffPersonalInfoId)
                 .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<StaffCompetenceTestTask>(p => p.StaffCompetenceTestTask)
                .WithOne(p => p.StaffCompetenceTest)
                .HasForeignKey(p => p.StaffCompetenceTestId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
