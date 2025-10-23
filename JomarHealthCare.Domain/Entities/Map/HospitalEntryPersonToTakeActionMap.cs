using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class HospitalEntryPersonToTakeActionMap : IEntityTypeConfiguration<HospitalEntryPersonToTakeAction>
    {
        public void Configure(EntityTypeBuilder<HospitalEntryPersonToTakeAction> builder)
        {
            builder.ToTable("tbl_HospitalEntryPersonToTakeAction");
            builder.HasKey(k => k.HospitalEntryPersonToTakeActionId);

            #region Properties
            builder.Property(p => p.HospitalEntryPersonToTakeActionId)
               .HasColumnName("HospitalEntryPersonToTakeActionId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.HospitalEntryId)
             .HasColumnName("HospitalEntryId")
             .IsRequired();

            #endregion
        }
    }
}
