using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class SeizureOfficerToActMap : IEntityTypeConfiguration<SeizureOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<SeizureOfficerToAct> builder)
        {
            builder.ToTable("tbl_Seizure_OfficerToAct");
            builder.HasKey(k => k.SeizureOfficerToActId);

            #region Properties
            builder.Property(p => p.SeizureOfficerToActId)
               .HasColumnName("SeizureOfficerToActId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.SeizureId)
             .HasColumnName("SeizureId")
             .IsRequired();

            #endregion
        }
    }
}
