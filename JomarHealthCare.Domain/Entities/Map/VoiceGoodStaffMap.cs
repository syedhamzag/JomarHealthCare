using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class VoiceGoodStaffMap : IEntityTypeConfiguration<VoiceGoodStaff>
    {
        public void Configure(EntityTypeBuilder<VoiceGoodStaff> builder)
        {
            builder.ToTable("tbl_Voice_GoodStaff");
            builder.HasKey(k => k.VoiceGoodStaffId);

            #region Properties
            builder.Property(p => p.VoiceGoodStaffId)
               .HasColumnName("VoiceGoodStaffId")
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
