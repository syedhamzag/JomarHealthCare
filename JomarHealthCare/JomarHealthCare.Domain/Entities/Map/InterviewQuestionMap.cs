using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class InterviewQuestionMap : IEntityTypeConfiguration<InterviewQuestion>
    {
        public void Configure(EntityTypeBuilder<InterviewQuestion> builder)
        {
            builder.ToTable("tbl_InterviewQuestion");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Question)
               .HasColumnName("Question");

            builder.Property(p => p.IsMandatory)
               .HasColumnName("IsMandatory");

            builder.Property(p => p.JobPosition)
               .HasColumnName("JobPosition");

            builder.Property(p => p.Marks)
               .HasColumnName("Marks");

            builder.Property(p => p.PassingMarks)
               .HasColumnName("PassingMarks");

            builder.Property(p => p.CreatedBy)
               .HasColumnName("CreatedBy")
               .HasMaxLength(450);

            builder.Property(p => p.InterviewType)
            .HasColumnName("InterviewType");
            #endregion
        }
    }
}
