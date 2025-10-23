using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BloodPressureOfficerToActMap : IEntityTypeConfiguration<BloodPressureOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<BloodPressureOfficerToAct> builder)
        {
            builder.ToTable("tbl_BloodPressure_OfficerToAct");
            builder.HasKey(k => k.BloodPressureOfficerToActId);

            #region Properties
            builder.Property(p => p.BloodPressureOfficerToActId)
               .HasColumnName("BloodPressureOfficerToActId")
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
