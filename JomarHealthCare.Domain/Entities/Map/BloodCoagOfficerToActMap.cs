using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BloodCoagOfficerToActMap : IEntityTypeConfiguration<BloodCoagOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<BloodCoagOfficerToAct> builder)
        {
            builder.ToTable("tbl_BloodCoag_OfficerToAct");
            builder.HasKey(k => k.BloodCoagOfficerToActId);

            #region Properties
            builder.Property(p => p.BloodCoagOfficerToActId)
               .HasColumnName("BloodCoagOfficerToActId")
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
