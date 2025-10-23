using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class DeductionForAllStaffMap : IEntityTypeConfiguration<DeductionForAllStaff>
    {
        public void Configure(EntityTypeBuilder<DeductionForAllStaff> builder)
        {
            builder.ToTable("tbl_DeductionForAllStaff");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Id)
               .HasColumnName("Id")
               .IsRequired();

            builder.Property(p => p.StaffId)
             .HasColumnName("StaffId")
             .IsRequired(false);

            builder.Property(p => p.StartDate)
          .HasColumnName("StartDate")
             .IsRequired();

            builder.Property(p => p.EndDate)
          .HasColumnName("EndDate")
          .IsRequired();
            #endregion
            builder.HasMany<DeductionValue>(p => p.DeductionValue)
         .WithOne(p => p.DeductionForAllStaff)
         .HasForeignKey(p => p.DeductionForAllStaffId)
         .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
