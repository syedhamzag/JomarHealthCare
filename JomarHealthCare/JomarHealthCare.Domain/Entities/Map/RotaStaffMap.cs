using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class RotaStaffMap : IEntityTypeConfiguration<RotaStaff>
    {
        public void Configure(EntityTypeBuilder<RotaStaff> builder)
        {
            builder.ToTable("tbl_RotaStaff");
            builder.HasKey(k => new { k.StaffId, k.StaffMedRotaId });


            #region relationships
            builder.HasOne(b => b.StaffMedRota)
                .WithMany(b => b.RotaStaff)
                .HasForeignKey(k => k.StaffMedRotaId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
