using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class AppointmentBookingAttendeesMap : IEntityTypeConfiguration<AppointmentBookingAttendees>
    {
        public void Configure(EntityTypeBuilder<AppointmentBookingAttendees> builder)
        {
            builder.ToTable("tbl_AppointmentBookingAttendees");
            builder.HasKey(k => k.AppointmentBookingAttendeesId);

            #region Properties
            builder.Property(p => p.AppointmentBookingAttendeesId)
               .HasColumnName("AppointmentBookingAttendeesId")
               .IsRequired();

            builder.Property(p => p.AttendeesId)
              .HasColumnName("AttendeesId")
              .HasMaxLength(38)
              .IsRequired();

            builder.Property(p => p.AppointmentBookingId)
             .HasColumnName("AppointmentBookingId")
             .IsRequired();

            #endregion
        }
    }
}
