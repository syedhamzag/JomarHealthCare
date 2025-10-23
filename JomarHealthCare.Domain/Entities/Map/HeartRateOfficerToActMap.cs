using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class HeartRateOfficerToActMap : IEntityTypeConfiguration<HeartRateOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<HeartRateOfficerToAct> builder)
        {
            builder.ToTable("tbl_HeartRate_OfficerToAct");
            builder.HasKey(k => k.HeartRateOfficerToActId);

            #region Properties
            builder.Property(p => p.HeartRateOfficerToActId)
               .HasColumnName("HeartRateOfficerToActId")
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
