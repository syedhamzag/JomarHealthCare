using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BloodPressurePhysicianMap : IEntityTypeConfiguration<BloodPressurePhysician>
    {
        public void Configure(EntityTypeBuilder<BloodPressurePhysician> builder)
        {
            builder.ToTable("tbl_BloodPressure_Physician");
            builder.HasKey(k => k.BloodPressurePhysicianId);

            #region Properties
            builder.Property(p => p.BloodPressurePhysicianId)
               .HasColumnName("BloodPressurePhysicianId")
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
