using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientShoppingMap : IEntityTypeConfiguration<ClientShopping>
    {
        public void Configure(EntityTypeBuilder<ClientShopping> builder)
        {
            builder.ToTable("tbl_Client_Shopping");
            builder.HasKey(p => p.ShoppingId);

            #region Properties
            builder.Property(p => p.ShoppingId)
                .HasColumnName("ShoppingId")
                .IsRequired();

            builder.Property(p => p.NutritionId)
               .HasColumnName("NutritionId")
               .IsRequired();

            builder.Property(p => p.MeansOfPurchase)
             .HasColumnName("MeansOfPurchase")
             .HasMaxLength(512);

            builder.Property(p => p.LocationOfPurchase)
             .HasColumnName("LocationOfPurchase")
              .HasMaxLength(512);

            builder.Property(p => p.Item)
             .HasColumnName("Item")
              .HasMaxLength(1024);

            builder.Property(p => p.Description)
             .HasColumnName("Description")
              .HasMaxLength(2048);

            builder.Property(p => p.DayOfShopping)
             .HasColumnName("DayOfShopping")
              .HasMaxLength(50);

            builder.Property(p => p.Image)
             .HasColumnName("Image")
             .HasMaxLength(1024);

            builder.Property(p => p.StaffId)
             .HasColumnName("StaffId")
             .HasMaxLength(38);
            #endregion

            #region Relationships
            builder.HasOne(p => p.ClientNutrition)
                .WithMany(p => p.ClientShopping)
                .HasForeignKey(p => p.NutritionId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
