using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CandidateInterviewMap : IEntityTypeConfiguration<CandidateInterview>
    {
        public void Configure(EntityTypeBuilder<CandidateInterview> builder)
        {
            builder.ToTable("tbl_CandidateInterview");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.StaffId)
               .HasColumnName("StaffId");

            builder.Property(p => p.JobPositionId)
               .HasColumnName("JobPositionId");

            builder.Property(p => p.PassingPercentage)
               .HasColumnName("PassingPercentage");

            builder.Property(p => p.ObtainPercentage)
               .HasColumnName("ObtainPercentage");

            builder.Property(p => p.Status)
               .HasColumnName("Status")
               .HasMaxLength(30);

            builder.Property(p => p.Comment)
               .HasColumnName("Comment")
               .HasMaxLength(1024);

            builder.Property(p => p.InterviewDate)
                .HasColumnName("InterviewDate");

            builder.Property(p => p.InterviwerStaff)
                .HasColumnName("InterviwerStaff")
                .HasMaxLength(50);

            builder.Property(p => p.CandidateSignature)
                .HasColumnName("CandidateSignature")
                .HasMaxLength(1024);

            builder.Property(p => p.InterviewType)
                .HasColumnName("InterviewType");
            #endregion
        }
    }
}
