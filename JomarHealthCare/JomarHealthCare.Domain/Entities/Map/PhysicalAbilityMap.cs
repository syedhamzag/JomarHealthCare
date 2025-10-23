using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PhysicalAbilityMap : IEntityTypeConfiguration<PhysicalAbility>
    {
        public void Configure(EntityTypeBuilder<PhysicalAbility> builder)
        {
            builder.ToTable("tbl_PhysicalAbility");
            builder.HasKey(k => k.PhysicalId);

            #region Properties
            builder.Property(p => p.PhysicalId)
               .HasColumnName("PhysicalId")
               .IsRequired();

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.Description)
               .HasColumnName("Description")
               .HasMaxLength(1024);

            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .HasMaxLength(512);

            #endregion
        }
    }
}
