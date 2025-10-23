using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CommunicationLogAttendeesMap : IEntityTypeConfiguration<CommunicationLogAttendees>
    {
        public void Configure(EntityTypeBuilder<CommunicationLogAttendees> builder)
        {
            builder.ToTable("tbl_CommunicationLogAttendees");
            builder.HasKey(k => k.CommunicationLogAttendeesId);

            #region Properties
            builder.Property(p => p.CommunicationLogAttendeesId)
               .HasColumnName("CommunicationLogAttendeesId")
               .IsRequired();

            builder.Property(p => p.AttendeesId)
              .HasColumnName("AttendeesId")
              .HasMaxLength(38)
              .IsRequired();

            builder.Property(p => p.CommunicationLogId)
             .HasColumnName("CommunicationLogId")
             .IsRequired();

            #endregion
        }
    }
}
