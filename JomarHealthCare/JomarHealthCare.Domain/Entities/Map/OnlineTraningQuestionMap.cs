using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class OnlineTraningQuestionMap: IEntityTypeConfiguration<OnlineTraningQuestion>
    {
        public void Configure(EntityTypeBuilder<OnlineTraningQuestion> builder)
        {
            builder.ToTable("tbl_OnlineTraningQuestion");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Question)
             .HasColumnName("Question")
             .HasMaxLength(1024);

            builder.Property(p => p.QuestionMarks)
             .HasColumnName("QuestionMarks");

            builder.Property(p => p.OnlineTraningId)
             .HasColumnName("OnlineTraningId");

            #endregion

            #region Relationship

            builder.HasOne(p => p.OnlineTraning)
             .WithMany(p => p.OnlineTraningQuestion)
             .HasForeignKey(p => p.OnlineTraningId)
             .OnDelete(DeleteBehavior.Cascade);
            
            #endregion
        }
    }
}
