using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class InspectionMap : IEntityTypeConfiguration<Inspection>
    {
        public void Configure(EntityTypeBuilder<Inspection> builder)
        {
            builder.ToTable("tbl_Inspection");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Date)
               .HasColumnName("Date");

            builder.Property(p => p.FileName)
               .HasColumnName("FileName")
               .HasMaxLength(512);

            builder.Property(p => p.FileURl)
               .HasColumnName("FileURl")
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
