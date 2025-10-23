using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class TrackingConcernStaffMap : IEntityTypeConfiguration<TrackingConcernStaff>
    {
        public void Configure(EntityTypeBuilder<TrackingConcernStaff> builder)
        {
            builder.ToTable("tbl_TrackingConcernStaff");
            builder.HasKey(k => k.TrackingConcernStaffId);

            #region Properties
            builder.Property(p => p.TrackingConcernStaffId)
               .HasColumnName("TrackingConcernManagerId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.TrackingConcernNoteId)
             .HasColumnName("TrackingConcernNoteId")
             .IsRequired();

            #endregion
        }
    }
}
