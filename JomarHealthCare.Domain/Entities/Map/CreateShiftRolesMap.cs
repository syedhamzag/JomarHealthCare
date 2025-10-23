using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CreateShiftRolesMap : IEntityTypeConfiguration<CreateShiftRoles>
    {
        public void Configure(EntityTypeBuilder<CreateShiftRoles> builder)
        {

            builder.ToTable("tbl_createshiftuserroles");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.HasOne(p => p.CreateShift)
             .WithMany(p => p.CreateShiftRoles)
             .HasForeignKey(p => p.ShiftId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.ClientFacility)
             .WithMany(p => p.CreateShiftRoles)
             .HasForeignKey(p => p.ClientFacilityId)
             .OnDelete(DeleteBehavior.Cascade);

            // builder.HasOne(p => p.Company)
            //  .WithMany(p => p.CreateShiftRoles)
            //  .HasForeignKey(p => p.CompanyId)
            //  .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.StaffUser)
             .WithMany(p => p.CreateShiftRoles)
             .HasForeignKey(p => p.StaffId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.Property(p => p.StaffJobCategory)
               .HasColumnName("StaffJobCategory")
               .IsRequired();

            builder.Property(p => p.StartTime)
              .HasColumnName("StartTime")
              .IsRequired();

            builder.Property(p => p.EndtTime)
              .HasColumnName("EndtTime")
              .IsRequired();

            builder.Property(p => p.IsBook)
              .HasColumnName("IsBook")
              .IsRequired();

            builder.Property(p => p.Deleted)
              .HasColumnName("Deleted")
              .IsRequired();
            #endregion

        }
    }
}

