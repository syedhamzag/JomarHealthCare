using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BloodCoagStaffNameMap : IEntityTypeConfiguration<BloodCoagStaffName>
    {
        public void Configure(EntityTypeBuilder<BloodCoagStaffName> builder)
        {
            builder.ToTable("tbl_BloodCoag_StaffName");
            builder.HasKey(k => k.BloodCoagStaffNameId);

            #region Properties
            builder.Property(p => p.BloodCoagStaffNameId)
               .HasColumnName("BloodCoagStaffNameId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.BloodRecordId)
             .HasColumnName("BloodRecordId")
             .IsRequired();

            #endregion
        }
    }
}
