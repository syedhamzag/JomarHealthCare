using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientMealDaysMap : IEntityTypeConfiguration<ClientMealDays>
    {
        public void Configure(EntityTypeBuilder<ClientMealDays> builder)
        {
            builder.ToTable("tbl_Client_MealDay");
            builder.HasKey(p => p.ClientMealId);

            #region Properties
            builder.Property(p => p.ClientMealId)
                .HasColumnName("ClientMealId")
                .IsRequired();

            builder.Property(p => p.NutritionId)
               .HasColumnName("NutritionId")
               .IsRequired();

            builder.Property(p => p.MealDetail)
             .HasColumnName("MealDetail")
             .HasMaxLength(2048);

            builder.Property(p => p.HowToPrepare)
             .HasColumnName("HowToPrepare")
             .HasMaxLength(2048);

            builder.Property(p => p.SeeVideo)
             .HasColumnName("SeeVideo")
             .HasMaxLength(1024);

            builder.Property(p => p.Picture)
             .HasColumnName("Picture")
             .HasMaxLength(1024);

            #endregion

            #region Relationships
            builder.HasOne(p => p.ClientNutrition)
                .WithMany(p => p.ClientMealDays)
                .HasForeignKey(p => p.NutritionId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
