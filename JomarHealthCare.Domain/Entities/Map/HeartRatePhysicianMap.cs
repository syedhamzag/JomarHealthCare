using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class HeartRatePhysicianMap : IEntityTypeConfiguration<HeartRatePhysician>
    {
        public void Configure(EntityTypeBuilder<HeartRatePhysician> builder)
        {
            builder.ToTable("tbl_HeartRate_Physician");
            builder.HasKey(k => k.HeartRatePhysicianId);

            #region Properties
            builder.Property(p => p.HeartRatePhysicianId)
               .HasColumnName("HeartRatePhysicianId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.HeartRateId)
             .HasColumnName("HeartRateId")
             .IsRequired();

            #endregion
        }
    }
}
