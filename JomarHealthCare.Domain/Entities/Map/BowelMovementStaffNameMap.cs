using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BowelMovementStaffNameMap : IEntityTypeConfiguration<BowelMovementStaffName>
    {
        public void Configure(EntityTypeBuilder<BowelMovementStaffName> builder)
        {
            builder.ToTable("tbl_BowelMovement_StaffName");
            builder.HasKey(k => k.BowelMovementStaffNameId);

            #region Properties
            builder.Property(p => p.BowelMovementStaffNameId)
               .HasColumnName("BowelMovementStaffNameId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.BowelMovementId)
             .HasColumnName("BowelMovementId")
             .IsRequired();

            #endregion
        }
    }
}
