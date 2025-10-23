using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class MealIntakeMap : IEntityTypeConfiguration<MealIntake>
    {
        public void Configure(EntityTypeBuilder<MealIntake> builder)
        {
            builder.ToTable("tbl_MealIntake");
            builder.HasKey(k => k.MealIntakeId);

            #region Properties
            builder.Property(p => p.StaffRotaPeriodId)
             .HasColumnName("StaffRotaPeriodId")
             .IsRequired(false);

            builder.Property(p => p.Name)
                .HasColumnName("Name")
                .IsRequired(false);

            builder.Property(p => p.Dose)
                           .HasColumnName("Dose")
                           .IsRequired(false);
       

            #endregion


        }
    }
}
