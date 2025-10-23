using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class TrainingMap : IEntityTypeConfiguration<Training>
    {
        public void Configure(EntityTypeBuilder<Training> builder)
        {
            builder.ToTable("tbl_Training");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Date)
               .HasColumnName("Date");

            builder.Property(p => p.Topic)
               .HasColumnName("Topic")
               .HasMaxLength(512);

            builder.Property(p => p.TrainingURl)
               .HasColumnName("TrainingURl")
               .HasMaxLength(512);

            builder.Property(p => p.Trainer)
               .HasColumnName("Trainer")
               .HasMaxLength(512);

            builder.Property(p => p.Remark)
               .HasColumnName("Remark")
               .HasMaxLength(512);

            builder.Property(p => p.Attachment)
               .HasColumnName("Attachment")
               .HasMaxLength(512);
            #endregion
        }
    }
}
