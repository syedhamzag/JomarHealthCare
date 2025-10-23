using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MeetingLogFacilitatorMap : IEntityTypeConfiguration<MeetingLogFacilitator>
    {
        public void Configure(EntityTypeBuilder<MeetingLogFacilitator> builder)
        {
            builder.ToTable("tbl_MeetingLogFacilitator");
            builder.HasKey(k => k.MeetingLogFacilitatorId);

            #region Properties
            builder.Property(p => p.MeetingLogFacilitatorId)
               .HasColumnName("MeetingLogFacilitatorId")
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
