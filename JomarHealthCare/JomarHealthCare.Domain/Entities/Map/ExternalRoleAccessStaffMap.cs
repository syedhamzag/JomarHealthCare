using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ExternalRoleAccessStaffMap : IEntityTypeConfiguration<ExternalRoleAccessStaff>
    {
        public void Configure(EntityTypeBuilder<ExternalRoleAccessStaff> builder)
        {
            builder.ToTable("tbl_ExternalRoleAccessStaff");
            builder.HasKey(k => k.ExternalRoleAccessStaffId);

            #region Properties
            builder.Property(p => p.ExternalRoleAccessStaffId)
               .HasColumnName("ExternalRoleAccessStaffId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .HasMaxLength(38)
              .IsRequired();

            builder.Property(p => p.ExternalAccessId)
             .HasColumnName("ExternalAccessId")
             .IsRequired();

            #endregion
        }
    }
}
