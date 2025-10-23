using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class FoodIntakePhysicianMap : IEntityTypeConfiguration<FoodIntakePhysician>
    {
        public void Configure(EntityTypeBuilder<FoodIntakePhysician> builder)
        {
            builder.ToTable("tbl_FoodIntake_Physician");
            builder.HasKey(k => k.FoodIntakePhysicianId);

            #region Properties
            builder.Property(p => p.FoodIntakePhysicianId)
               .HasColumnName("FoodIntakePhysicianId")
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
