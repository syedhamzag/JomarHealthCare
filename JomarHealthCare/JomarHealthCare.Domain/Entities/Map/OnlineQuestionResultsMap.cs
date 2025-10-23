using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class OnlineQuestionResultsMap : IEntityTypeConfiguration<OnlineQuestionResults>
    {
        public void Configure(EntityTypeBuilder<OnlineQuestionResults> builder)
        {
            builder.ToTable("tbl_OnlineQuestionResults");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.OnlineTrainingId)
             .HasColumnName("OnlineTrainingId");

            builder.Property(p => p.QuestionId)
             .HasColumnName("QuestionId");

            builder.Property(p => p.OptionId)
             .HasColumnName("OptionId");

            builder.Property(p => p.staffId)
              .HasColumnName("staffId");
            
            builder.Property(p => p.BundleResultId)
              .HasColumnName("BundleResultId");
            #endregion
        }
    }
}
