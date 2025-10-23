using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    internal class FocusedFeedbackMap : IEntityTypeConfiguration<FocusedFeedback>
    {
        public void Configure(EntityTypeBuilder<FocusedFeedback> builder)
        {
            builder.ToTable("tbl_FocusedFeedback");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Date)
               .HasColumnName("Date");

            builder.Property(p => p.Topic)
               .HasColumnName("Topic")
               .HasMaxLength(512);

            builder.Property(p => p.FileURl)
               .HasColumnName("FileURl")
               .HasMaxLength(512);

            builder.Property(p => p.Reason)
               .HasColumnName("Reason")
               .HasMaxLength(512);

            builder.Property(p => p.Remark)
               .HasColumnName("Remark")
               .HasMaxLength(512);

            builder.Property(p => p.ConductedBy)
               .HasColumnName("ConductedBy")
               .HasMaxLength(512);
            #endregion
        }
    }
}
