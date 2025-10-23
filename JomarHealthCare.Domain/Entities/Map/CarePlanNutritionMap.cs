using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CarePlanNutritionMap : IEntityTypeConfiguration<CarePlanNutrition>
    {
        public void Configure(EntityTypeBuilder<CarePlanNutrition> builder)
        {
            builder.ToTable("tbl_CarePlanNutrition");
            builder.HasKey(k => k.NutritionId);

            #region Properties

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.AvoidFood)
               .HasColumnName("AvoidFood")
               .HasMaxLength(1024);

            builder.Property(p => p.DrinkType)
               .HasColumnName("DrinkType")
               .HasMaxLength(1024);

            builder.Property(p => p.SpecialDiet)
               .HasColumnName("SpecialDiet")
               .HasMaxLength(1024);

            builder.Property(p => p.RiskMitigations)
               .HasColumnName("RiskMitigations")
               .HasMaxLength(1024);

            builder.Property(p => p.WhenRestock)
               .HasColumnName("WhenRestock")
               .HasMaxLength(1024);

            builder.Property(p => p.ServingMeal)
                .HasColumnName("ServingMeal")
                .HasMaxLength(1024);

            #endregion
        }
    }
}
