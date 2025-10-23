using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MeetingLogAttendeMap : IEntityTypeConfiguration<MeetingLogAttende>
    {
        public void Configure(EntityTypeBuilder<MeetingLogAttende> builder)
        {
            builder.ToTable("tbl_MeetingLogAttende");
            builder.HasKey(k => k.MeetingLogAttendeId);

            #region Properties
            builder.Property(p => p.MeetingLogAttendeId)
               .HasColumnName("MeetingLogAttendeId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.MeetingLogId)
             .HasColumnName("MeetingLogId")
             .IsRequired();

            #endregion
        }
    }
}
