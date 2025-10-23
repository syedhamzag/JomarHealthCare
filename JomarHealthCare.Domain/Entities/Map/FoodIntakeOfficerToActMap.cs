using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class FoodIntakeOfficerToActMap : IEntityTypeConfiguration<FoodIntakeOfficerToAct>
    {
        public void Configure(EntityTypeBuilder<FoodIntakeOfficerToAct> builder)
        {
            builder.ToTable("tbl_FoodIntake_OfficerToAct");
            builder.HasKey(k => k.FoodIntakeOfficerToActId);

            #region Properties
            builder.Property(p => p.FoodIntakeOfficerToActId)
               .HasColumnName("FoodIntakeOfficerToActId")
               .IsRequired();

            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.FoodIntakeId)
             .HasColumnName("FoodIntakeId")
             .IsRequired();

            #endregion
        }
    }
}
