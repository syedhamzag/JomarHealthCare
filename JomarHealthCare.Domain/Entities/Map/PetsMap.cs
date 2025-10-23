using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PetsMap : IEntityTypeConfiguration<Pets>
    {
        public void Configure(EntityTypeBuilder<Pets> builder)
        {
            builder.ToTable("tbl_Pets");
            builder.HasKey(k => k.PetsId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .HasMaxLength(256);


            builder.Property(p => p.PetActivities)
                .HasColumnName("PetActivities")
                .HasMaxLength(2024);

            builder.Property(p => p.PetCare)
               .HasColumnName("PetCare")
               .HasMaxLength(2024);

            builder.Property(p => p.MealPattern)
               .HasColumnName("MealPattern")
               .HasMaxLength(2024);
            #endregion
        }
    }
}
