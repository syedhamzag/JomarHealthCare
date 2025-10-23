using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PulseRateOfficerToActMap : IEntityTypeConfiguration<PulseRateOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<PulseRateOfficerToAct> builder)
        {
            builder.ToTable("tbl_PulseRate_OfficerToAct");
            builder.HasKey(k => k.PulseRateOfficerToActId);

            #region Properties
            builder.Property(p => p.PulseRateOfficerToActId)
               .HasColumnName("PulseRateOfficerToActId")
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
