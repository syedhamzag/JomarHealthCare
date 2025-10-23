using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BloodPressureStaffNameMap : IEntityTypeConfiguration<BloodPressureStaffName>
    {
        public void Configure(EntityTypeBuilder<BloodPressureStaffName> builder)
        {
            builder.ToTable("tbl_BloodPressure_StaffName");
            builder.HasKey(k => k.BloodPressureStaffNameId);

            #region Properties
            builder.Property(p => p.BloodPressureStaffNameId)
               .HasColumnName("BloodPressureStaffNameId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.BloodPressureId)
             .HasColumnName("BloodPressureId")
             .IsRequired();

            #endregion
        }
    }
}
