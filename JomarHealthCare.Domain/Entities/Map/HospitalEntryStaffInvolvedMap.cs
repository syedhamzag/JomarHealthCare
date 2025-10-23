using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class HospitalEntryStaffInvolvedMap : IEntityTypeConfiguration<HospitalEntryStaffInvolved>
    {
        public void Configure(EntityTypeBuilder<HospitalEntryStaffInvolved> builder)
        {
            builder.ToTable("tbl_HospitalEntryStaffInvolved");
            builder.HasKey(k => k.HospitalEntryStaffInvolvedId);

            #region Properties
            builder.Property(p => p.HospitalEntryStaffInvolvedId)
               .HasColumnName("HospitalEntryStaffInvolvedId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.HospitalEntryId)
             .HasColumnName("HospitalEntryId")
             .IsRequired();

            #endregion
        }
    }
}
