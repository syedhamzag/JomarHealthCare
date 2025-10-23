using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class AppointmentBookingMap : IEntityTypeConfiguration<AppointmentBooking>
    {
        public void Configure(EntityTypeBuilder<AppointmentBooking> builder)
        {
            builder.ToTable("tbl_AppointmentBooking");
            builder.HasKey(k => k.AppointmentBookingId);

            #region Properties
            builder.Property(p => p.AppointmentBookingId)
               .HasColumnName("AppointmentBookingId")
               .IsRequired();

            builder.Property(p => p.Subject)
               .HasColumnName("Subject")
               .HasMaxLength(150);

            builder.Property(p => p.Date)
               .HasColumnName("Date")
               .IsRequired();

            builder.Property(p => p.Class)
               .HasColumnName("Class")
               .IsRequired();

            builder.Property(p => p.Type)
               .HasColumnName("Type")
               .IsRequired();

            builder.Property(p => p.Location)
               .HasColumnName("Location")
               .HasMaxLength(1024);

            builder.Property(p => p.Link)
               .HasColumnName("Link")
               .HasMaxLength(1024);

            builder.Property(p => p.CompanyId)
               .HasColumnName("CompanyId")
               .HasMaxLength(38);

            builder.Property(p => p.AttendeeName)
               .HasColumnName("AttendeeName")
               .HasMaxLength(1024);

            builder.Property(p => p.Status)
               .HasColumnName("Status")
               .IsRequired();

            builder.Property(p => p.Comments)
               .HasColumnName("Comments")
               .IsRequired(false);
            #endregion

            #region Relationship
            builder.HasMany<AppointmentBookingAttendees>(p => p.Attendee)
                .WithOne(p => p.AppointmentBooking)
                .HasForeignKey(p => p.AppointmentBookingId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion
        }
    }
}
