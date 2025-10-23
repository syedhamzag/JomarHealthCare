using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class OnlineLogQuestionResultsMap : IEntityTypeConfiguration<OnlineLogQuestionResults>
    {
        public void Configure(EntityTypeBuilder<OnlineLogQuestionResults> builder)
        {
            builder.ToTable("tbl_OnlineLogQuestionResults");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.OnlineTrainingId)
             .HasColumnName("OnlineTrainingId");

            builder.Property(p => p.LogQuestionId)
             .HasColumnName("LogQuestionId");

            builder.Property(p => p.BeforeAnswer)
             .HasColumnName("BeforeAnswer");

            builder.Property(p => p.DuringAnswer)
             .HasColumnName("DuringAnswer");

            builder.Property(p => p.AfterAnswer)
             .HasColumnName("AfterAnswer");

            builder.Property(p => p.ObtainMark)
             .HasColumnName("ObtainMark");

            builder.Property(p => p.staffId)
              .HasColumnName("staffId");

              builder.Property(p => p.BundleId)
              .HasColumnName("BundleId");
            #endregion
        }
    }
}
