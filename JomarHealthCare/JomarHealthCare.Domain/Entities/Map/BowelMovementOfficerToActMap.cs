using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BowelMovementOfficerToActMap : IEntityTypeConfiguration<BowelMovementOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<BowelMovementOfficerToAct> builder)
        {
            builder.ToTable("tbl_BowelMovement_OfficerToAct");
            builder.HasKey(k => k.BowelMovementOfficerToActId);

            #region Properties
            builder.Property(p => p.BowelMovementOfficerToActId)
               .HasColumnName("BowelMovementOfficerToActId")
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
