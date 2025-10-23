using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class KeyIndicatorsMap : IEntityTypeConfiguration<KeyIndicators>
    {
        public void Configure(EntityTypeBuilder<KeyIndicators> builder)
        {
            builder.ToTable("tbl_KeyIndicators");
            builder.HasKey(k => k.KeyId);

            #region Properties

            builder.Property(p => p.KeyId)
               .HasColumnName("KeyId")
               .IsRequired();

            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);


            builder.Property(p => p.LogMethod)
              .HasColumnName("LogMethod")
              .HasMaxLength(50);
            #endregion

        }
    }
}
