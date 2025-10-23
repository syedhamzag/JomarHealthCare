using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffPersonalityTestMap : IEntityTypeConfiguration<StaffPersonalityTest>
    {
        public void Configure(EntityTypeBuilder<StaffPersonalityTest> builder)
        {
            builder.ToTable("tbl_StaffPersonalityTest");
            builder.HasKey(k => k.TestId);

            #region Properties
            builder.Property(p => p.TestId)
               .HasColumnName("TestId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
               .HasColumnName("StaffPersonalInfoId")
               .IsRequired();

            builder.Property(p => p.Question)
               .HasColumnName("Question")
               .IsRequired();

            builder.Property(p => p.Answer)
               .HasColumnName("Answer")
               .IsRequired();
            #endregion

            #region Relationship
            builder.HasOne(p => p.StaffPersonalInfo)
                 .WithMany(p => p.StaffPersonalityTest)
                 .HasForeignKey(p => p.StaffPersonalInfoId)
                 .OnDelete(DeleteBehavior.Cascade);

            #endregion
        }
    }
}
