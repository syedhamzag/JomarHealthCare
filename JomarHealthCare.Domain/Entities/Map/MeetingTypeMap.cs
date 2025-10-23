using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MeetingTypeMap : IEntityTypeConfiguration<MeetingType>
    {
        public void Configure(EntityTypeBuilder<MeetingType> builder)
        {
            builder.ToTable("tbl_MeetingType");
            builder.HasKey(k => k.MeetingTypeId);

            #region Properties
            builder.Property(p => p.MeetingTypeId)
                .HasColumnName("MeetingTypeId")
                .IsRequired();

            builder.Property(p => p.MeetingName)
               .HasColumnName("MeetingName")
               .HasMaxLength(225)
               .IsRequired(true);

            builder.Property(p => p.CreatedBy)
          .HasColumnName("CreatedBy")
          .IsRequired(false);
            #endregion
        }
    }
}
