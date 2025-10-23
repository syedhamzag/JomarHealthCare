using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class EyeHealthStaffNameMap : IEntityTypeConfiguration<EyeHealthStaffName>
    {
        public void Configure(EntityTypeBuilder<EyeHealthStaffName> builder)
        {
            builder.ToTable("tbl_EyeHealth_StaffName");
            builder.HasKey(k => k.EyeHealthStaffNameId);

            #region Properties
            builder.Property(p => p.EyeHealthStaffNameId)
               .HasColumnName("EyeHealthStaffNameId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.EyeHealthId)
             .HasColumnName("EyeHealthId")
             .IsRequired();

            #endregion
        }
    }
}
