using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CandidateInterviewResultMap : IEntityTypeConfiguration<CandidateInterviewResult>
    {
        public void Configure(EntityTypeBuilder<CandidateInterviewResult> builder)
        {
            builder.ToTable("tbl_CandidateInterviewResult");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.QuestionId)
               .HasColumnName("QuestionId");

            builder.Property(p => p.Answer)
               .HasColumnName("Answer");

            builder.Property(p => p.Point)
               .HasColumnName("Point");

            builder.Property(p => p.CandidateInterviewId)
               .HasColumnName("CandidateInterviewId");
            #endregion
        }
    }
}
