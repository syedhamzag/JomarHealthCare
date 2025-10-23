using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class InfectionControlMap : IEntityTypeConfiguration<InfectionControl>
    {
        public void Configure(EntityTypeBuilder<InfectionControl> builder)
        {
            builder.ToTable("tbl_InfectionControl");
            builder.HasKey(k => k.InfectionId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);


            builder.Property(p => p.Guideline)
               .HasColumnName("Guideline")
               .HasMaxLength(2024);

            builder.Property(p => p.Remarks)
               .HasColumnName("Remarks")
               .HasMaxLength(2024);
            #endregion
        }
    }
}
