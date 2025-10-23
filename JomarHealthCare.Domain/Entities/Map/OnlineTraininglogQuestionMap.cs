using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class OnlineTraininglogQuestionMap : IEntityTypeConfiguration<OnlineTraininglogQuestion>
    {
        public void Configure(EntityTypeBuilder<OnlineTraininglogQuestion> builder)
        {
            builder.ToTable("tbl_OnlineTraininglogQuestion");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.BeforeQuestion)
             .HasColumnName("BeforeQuestion");

            builder.Property(p => p.DuringQuestion)
             .HasColumnName("DuringQuestion");

            builder.Property(p => p.AfterQuestion)
             .HasColumnName("AfterQuestion");

            builder.Property(p => p.OnlineTraningId)
             .HasColumnName("OnlineTraningId");

            #endregion

            #region Relationship

            builder.HasOne(p => p.OnlineTraning)
             .WithMany(p => p.OnlineTraininglogQuestion)
             .HasForeignKey(p => p.OnlineTraningId)
             .OnDelete(DeleteBehavior.Cascade);

            #endregion
        }
    }
}
