using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PulseRatePhysicianMap : IEntityTypeConfiguration<PulseRatePhysician>
    {
        public void Configure(EntityTypeBuilder<PulseRatePhysician> builder)
        {
            builder.ToTable("tbl_PulseRate_Physician");
            builder.HasKey(k => k.PulseRatePhysicianId);

            #region Properties
            builder.Property(p => p.PulseRatePhysicianId)
               .HasColumnName("PulseRatePhysicianId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.PulseRateId)
             .HasColumnName("PulseRateId")
             .IsRequired();

            #endregion
        }
    }
}
