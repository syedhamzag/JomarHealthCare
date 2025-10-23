using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class AssignAlertStaffMap : IEntityTypeConfiguration<AssignAlertStaff>
    {
        public void Configure(EntityTypeBuilder<AssignAlertStaff> builder)
        {
            builder.ToTable("tbl_assignalertstaff");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.HasOne(p => p.StaffAlert)
             .WithMany(p => p.AssignAlertStaff)
             .HasForeignKey(p => p.StaffAlertId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.StaffPersonalInfo)
             .WithMany(p => p.AssignAlertStaff)
             .HasForeignKey(p => p.StaffId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.Property(p => p.Deleted)
              .HasColumnName("Deleted")
              .IsRequired();
            #endregion
        }
    }
}
