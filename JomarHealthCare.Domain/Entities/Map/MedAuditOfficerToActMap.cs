using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MedAuditOfficerToActMap : IEntityTypeConfiguration<MedAuditOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<MedAuditOfficerToAct> builder)
        {
            builder.ToTable("tbl_MedAudit_OfficerToAct");
            builder.HasKey(k => k.MedAuditOfficerToActId);

            #region Properties
            builder.Property(p => p.MedAuditOfficerToActId)
               .HasColumnName("MedAuditOfficerToActId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.MedAuditId)
             .HasColumnName("MedAuditId")
             .IsRequired();

            #endregion
        }
    }
}
