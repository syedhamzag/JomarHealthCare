using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class TrainingRequirementMap: IEntityTypeConfiguration<TrainingRequirement>
    {
        public void Configure(EntityTypeBuilder<TrainingRequirement> builder)
        {
            builder.ToTable("tbl_TrainingRequirement");
            builder.HasKey(p => p.Id);

            #region Properties
            builder.Property(p => p.Name)
              .HasColumnName("Name")
              .HasMaxLength(256);

            builder.Property(p => p.Notes)
               .HasColumnName("Notes")
               .HasMaxLength(1052);

            builder.Property(p => p.Attachment)
                .HasColumnName("KeyName")
                .HasMaxLength(512);

            #endregion
        }
    }
}
