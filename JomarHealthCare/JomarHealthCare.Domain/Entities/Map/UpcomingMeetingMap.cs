using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class UpcomingMeetingMap : IEntityTypeConfiguration<UpcomingMeeting>
    {
        public void Configure(EntityTypeBuilder<UpcomingMeeting> builder)
        {
            builder.ToTable("tbl_UpcomingMeeting");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.MeetingDate)
               .HasColumnName("MeetingDate");

            builder.Property(p => p.CalledBy)
               .HasColumnName("CalledBy");

            builder.Property(p => p.Location)
               .HasColumnName("Location")
               .HasMaxLength(256);

            builder.Property(p => p.Time)
               .HasColumnName("Time");


            builder.Property(p => p.CreatedBy)
               .HasColumnName("CreatedBy");

            #endregion
        }
    }
}
