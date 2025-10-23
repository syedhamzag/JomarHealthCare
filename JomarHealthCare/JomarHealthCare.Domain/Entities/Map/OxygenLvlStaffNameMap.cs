using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class OxygenLvlStaffNameMap : IEntityTypeConfiguration<OxygenLvlStaffName>
    {
        public void Configure(EntityTypeBuilder<OxygenLvlStaffName> builder)
        {
            builder.ToTable("tbl_OxygenLvl_StaffName");
            builder.HasKey(k => k.OxygenLvlStaffNameId);

            #region Properties
            builder.Property(p => p.OxygenLvlStaffNameId)
               .HasColumnName("OxygenLvlStaffNameId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.OxygenLvlId)
             .HasColumnName("OxygenLvlId")
             .IsRequired();

            #endregion
        }
    }
}
