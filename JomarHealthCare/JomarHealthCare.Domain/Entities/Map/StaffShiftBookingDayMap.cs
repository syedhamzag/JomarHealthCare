using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffShiftBookingDayMap : IEntityTypeConfiguration<StaffShiftBookingDay>
    {
        public void Configure(EntityTypeBuilder<StaffShiftBookingDay> builder)
        {
            builder.ToTable("tbl_StaffShiftBookingDay");
            builder.HasKey(p => p.StaffShiftBookingDayId);

            #region Properties
            builder.Property(p => p.StaffShiftBookingDayId)
                .HasColumnName("StaffShiftBookingDayId")
                .IsRequired();

            builder.Property(p => p.StaffShiftBookingId)
               .HasColumnName("StaffShiftBookingId")
               .IsRequired();

            builder.Property(p => p.Day)
              .HasColumnName("Day")
              .HasMaxLength(2)
              .IsRequired();

            builder.Property(p => p.WeekDay)
              .HasColumnName("WeekDay")
              .HasMaxLength(15)
              .IsRequired();

            builder.Property(p => p.Date)
               .HasColumnName("Date")
               .IsRequired();

            builder.Property(p => p.IsDelete)
               .HasColumnName("IsDelete");
            #endregion

            #region Relationship
            builder.HasOne(p => p.ShiftBooking)
                .WithMany(p => p.Days)
                .HasForeignKey(k=>k.StaffShiftBookingId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
