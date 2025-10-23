using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class BalanceMap : IEntityTypeConfiguration<Balance>
    {
        public void Configure(EntityTypeBuilder<Balance> builder)
        {
            builder.ToTable("tbl_Balance");
            builder.HasKey(k => k.BalanceId);

            #region Properties

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
