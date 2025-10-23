using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BloodCoagPhysicianMap : IEntityTypeConfiguration<BloodCoagPhysician>
    {
        public void Configure(EntityTypeBuilder<BloodCoagPhysician> builder)
        {
            builder.ToTable("tbl_BloodCoag_Physician");
            builder.HasKey(k => k.BloodCoagPhysicianId);

            #region Properties
            builder.Property(p => p.BloodCoagPhysicianId)
               .HasColumnName("BloodCoagPhysicianId")
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
