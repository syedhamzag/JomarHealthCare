using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientCleaningMap : IEntityTypeConfiguration<ClientCleaning>
    {
        public void Configure(EntityTypeBuilder<ClientCleaning> builder)
        {
            builder.ToTable("tbl_Client_Cleaning");
            builder.HasKey(p => p.CleaningId);

            #region Properties
            builder.Property(p => p.CleaningId)
                .HasColumnName("CleaningId")
                .IsRequired();

            builder.Property(p => p.NutritionId)
               .HasColumnName("NutritionId")
               .IsRequired();

            builder.Property(p => p.Details)
             .HasColumnName("Details")
             .HasMaxLength(1024);

            builder.Property(p => p.SafetyHazard)
             .HasColumnName("SafetyHazard")
              .HasMaxLength(512);

            builder.Property(p => p.LocationOfItem)
             .HasColumnName("LocationOfItem")
              .HasMaxLength(512);

            builder.Property(p => p.DescOfItem)
             .HasColumnName("DescOfItem")
              .HasMaxLength(50);

            builder.Property(p => p.Disposal)
             .HasColumnName("Disposal")
              .HasMaxLength(50)
             .IsRequired();

            builder.Property(p => p.DayOfCleaning)
             .HasColumnName("DayOfCleaning")
              .HasMaxLength(50);

            builder.Property(p => p.WhereToKeep)
             .HasColumnName("WhereToKeep")
             .HasMaxLength(512);

            builder.Property(p => p.SeeVideo)
             .HasColumnName("SeeVideo")
              .HasMaxLength(1024);

            builder.Property(p => p.Image)
             .HasColumnName("Image")
             .HasMaxLength(1024);

            builder.Property(p => p.StaffId)
                .HasColumnName("StaffId")
                .HasMaxLength(38);
            #endregion

            #region Relationships
            builder.HasOne(p => p.ClientNutrition)
                .WithMany(p => p.ClientCleaning)
                .HasForeignKey(p => p.NutritionId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
