using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    
    public class StaffPayRollSettingMap : IEntityTypeConfiguration<StaffPayRollSetting>
    {
        public void Configure(EntityTypeBuilder<StaffPayRollSetting> builder)
        {
            builder.ToTable("tbl_StaffPayRollSetting");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.FixedAmount)
               .HasColumnName("FixedAmount")
               .IsRequired();

            builder.Property(p => p.FixedAmountTypeId)
             .HasColumnName("FixedAmountTypeId")
             .IsRequired();

            builder.Property(p => p.StaffRateTypeId)
            .HasColumnName("StaffRateTypeId")
            .IsRequired();

             builder.Property(p => p.CategoryOfStaffId)
             .HasColumnName("CategoryOfStaffId")
             .IsRequired();

             builder.Property(p => p.TypeOfStaffServiceId)
            .HasColumnName("TypeOfStaffServiceId")
            .IsRequired();

            builder.Property(p => p.ClassOfStaffId)
           .HasColumnName("ClassOfStaffId")
           .IsRequired();

            builder.Property(p => p.TeamOfStaffId)
           .HasColumnName("TeamOfStaffId")
           .IsRequired();

            builder.Property(p => p.StaffId)
           .HasColumnName("StaffId")
           .IsRequired();

            builder.Property(p => p.MinHr)
           .HasColumnName("MinHr");

            builder.Property(p => p.MaxHr)
           .HasColumnName("MaxHr");
            #endregion
        }
    }
}
