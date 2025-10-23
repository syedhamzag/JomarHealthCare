using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MedAuditStaffNameMap : IEntityTypeConfiguration<MedAuditStaffName>
    {
        public void Configure(EntityTypeBuilder<MedAuditStaffName> builder)
        {
            builder.ToTable("tbl_MedAudit_AuditorName");
            builder.HasKey(k => k.MedAuditStaffNameId);

            #region Properties
            builder.Property(p => p.MedAuditStaffNameId)
               .HasColumnName("MedAuditStaffNameId")
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
