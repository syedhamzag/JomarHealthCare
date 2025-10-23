using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class VoiceOfficerToActMap : IEntityTypeConfiguration<VoiceOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<VoiceOfficerToAct> builder)
        {
            builder.ToTable("tbl_Voice_OfficerToAct");
            builder.HasKey(k => k.VoiceOfficerToActId);

            #region Properties
            builder.Property(p => p.VoiceOfficerToActId)
               .HasColumnName("VoiceOfficerToActId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.VoiceId)
             .HasColumnName("VoiceId")
             .IsRequired();

            #endregion
        }
    }
}
