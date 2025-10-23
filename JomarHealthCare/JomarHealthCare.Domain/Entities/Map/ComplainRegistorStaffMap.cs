using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ComplainRegistorStaffMap : IEntityTypeConfiguration<ComplainRegistorStaff>
    {
        public void Configure(EntityTypeBuilder<ComplainRegistorStaff> builder)
        {
            builder.ToTable("tbl_ComplainRegistorStaff");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.StaffId)
               .HasColumnName("StaffId")
               .HasMaxLength(38);

            builder.Property(p => p.ComplainRegistorId)
               .HasColumnName("ComplainRegistorId");

            builder.Property(p => p.StaffResponse)
               .HasColumnName("StaffResponse")
               .HasMaxLength(1056);
            #endregion

            builder.HasOne(p => p.ComplainRegistor)
             .WithMany(p => p.ComplainRegistorStaff)
             .HasForeignKey(p => p.ComplainRegistorId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Staff)
             .WithMany(p => p.ComplainRegistorStaff)
             .HasForeignKey(p => p.StaffId)
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
