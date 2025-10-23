using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class WoundCareStaffNameMap : IEntityTypeConfiguration<WoundCareStaffName>
    {
        public void Configure(EntityTypeBuilder<WoundCareStaffName> builder)
        {
            builder.ToTable("tbl_WoundCare_StaffName");
            builder.HasKey(k => k.WoundCareStaffNameId);

            #region Properties
            builder.Property(p => p.WoundCareStaffNameId)
               .HasColumnName("WoundCareStaffNameId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.WoundCareId)
             .HasColumnName("WoundCareId")
             .IsRequired();

            #endregion
        }
    }
}
