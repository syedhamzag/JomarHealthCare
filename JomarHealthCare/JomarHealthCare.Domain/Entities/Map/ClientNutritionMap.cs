using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientNutritionMap : IEntityTypeConfiguration<ClientNutrition>
    {
        public void Configure(EntityTypeBuilder<ClientNutrition> builder)
        {
            builder.ToTable("tbl_Client_Nutrition");
            builder.HasKey(p => p.NutritionId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.StaffId)
               .HasColumnName("StaffId")
               .HasMaxLength(38);

            builder.Property(p => p.MealSpecialNote)
               .HasColumnName("MealSpecialNote")
               .HasMaxLength(2048);

            builder.Property(p => p.ShoppingSpecialNote)
               .HasColumnName("ShoppingSpecialNote")
               .HasMaxLength(2048);

            builder.Property(p => p.CleaningSpecialNote)
               .HasColumnName("CleaningSpecialNote")
               .HasMaxLength(2048);
            #endregion
        }
    }
}
