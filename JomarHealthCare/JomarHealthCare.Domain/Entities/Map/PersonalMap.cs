using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PersonalMap : IEntityTypeConfiguration<Personal>
    {
        public void Configure(EntityTypeBuilder<Personal> builder)
        {
            builder.ToTable("tbl_Personal");
            builder.HasKey(k => k.PersonalId);

            #region Properties
            builder.Property(p => p.ClientId)
               .HasColumnName("ClientId")
               .HasMaxLength(38);

            builder.Property(p => p.Religion)
               .HasColumnName("Religion")
               .HasMaxLength(256);

            builder.Property(p => p.Nationality)
               .HasColumnName("Nationality")
               .HasMaxLength(256);
            #endregion
        }
    }
}
