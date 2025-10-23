using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BodyTempStaffNameMap : IEntityTypeConfiguration<BodyTempStaffName>
    {
        public void Configure(EntityTypeBuilder<BodyTempStaffName> builder)
        {
            builder.ToTable("tbl_BodyTemp_StaffName");
            builder.HasKey(k => k.BodyTempStaffNameId);

            #region Properties
            builder.Property(p => p.BodyTempStaffNameId)
               .HasColumnName("BodyTempStaffNameId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.BodyTempId)
             .HasColumnName("BodyTempId")
             .IsRequired();

            #endregion
        }
    }
}
