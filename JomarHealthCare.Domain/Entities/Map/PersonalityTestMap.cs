using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PersonalityTestMap : IEntityTypeConfiguration<PersonalityTest>
    {
        public void Configure(EntityTypeBuilder<PersonalityTest> builder)
        {
            builder.ToTable("tbl_PersonalityTest");
            builder.HasKey(k => k.TestId);

            #region Properties
            builder.Property(p => p.TestId)
               .HasColumnName("TestId")
               .IsRequired();

            builder.Property(p => p.GoalId)
               .HasColumnName("GoalId")
               .IsRequired();

            builder.Property(p => p.Question)
               .HasColumnName("Question")
               .IsRequired();

            builder.Property(p => p.Answer)
               .HasColumnName("Answer")
               .IsRequired();
            #endregion
        }
    }
}
