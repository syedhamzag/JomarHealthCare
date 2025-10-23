using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffHolidayMap : IEntityTypeConfiguration<StaffHoliday>
    {
        public void Configure(EntityTypeBuilder<StaffHoliday> builder)
        {
            builder.ToTable("tbl_StaffHoliday");
            builder.HasKey(k => k.StaffHolidayId);

            #region Properties
            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.YearOfService)
              .HasColumnName("YearOfService")
              .IsRequired();

            builder.Property(p => p.AllocatedDays)
             .HasColumnName("AllocatedDays")
             .IsRequired();

            builder.Property(p => p.StartDate)
             .HasColumnName("StartDate")
             .IsRequired();

            builder.Property(p => p.EndDate)
             .HasColumnName("EndDate")
             .IsRequired();

            builder.Property(p => p.Days)
             .HasColumnName("Days")
             .IsRequired();

            builder.Property(p => p.Purpose)
             .HasColumnName("Purpose")
             .IsRequired(false);

            builder.Property(p => p.Class)
             .HasColumnName("Class")
             .IsRequired();

            builder.Property(p => p.PersonOnResponsibility)
             .HasColumnName("PersonOnResponsibility")
             .IsRequired(false);

            builder.Property(p => p.CopyOfHandover)
             .HasColumnName("CopyOfHandover")
             .IsRequired(false);

            builder.Property(p => p.Remark)
             .HasColumnName("Remark")
             .HasMaxLength(1024)
             .IsRequired(false);

            builder.Property(p => p.Attachment)
             .HasColumnName("Attachment")
             .HasMaxLength (1024)
             .IsRequired(false);

            builder.Property(p => p.Status)
             .HasColumnName("Status")
             .HasMaxLength(30);

            builder.Property(p => p.CompanyId)
             .HasColumnName("CompanyId")
             .HasMaxLength(450);
            #endregion

            #region Relationship
            builder.HasOne(p => p.StaffPersonalInfo)
                .WithMany(m => m.StaffHoliday)
                .HasForeignKey(f => f.StaffPersonalInfoId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
