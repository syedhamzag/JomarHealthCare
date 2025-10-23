using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MeetingLogResponsibleToActMap : IEntityTypeConfiguration<MeetingLogResponsibleToAct>
    {
        public void Configure(EntityTypeBuilder<MeetingLogResponsibleToAct> builder)
        {
            builder.ToTable("tbl_MeetingLogResponsibleToAct");
            builder.HasKey(k => k.MeetingLogResponsibleId);

            #region Properties
            builder.Property(p => p.MeetingLogResponsibleId)
               .HasColumnName("MeetingLogResponsibleId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.MeetingLogId)
             .HasColumnName("MeetingLogId")
             .IsRequired();

            #endregion
        }
    }
}
