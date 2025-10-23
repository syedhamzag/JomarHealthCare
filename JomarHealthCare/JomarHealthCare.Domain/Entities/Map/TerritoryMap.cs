using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    internal class TerritoryMap : IEntityTypeConfiguration<Territory>
    {
        public void Configure(EntityTypeBuilder<Territory> builder)
        {
            builder.ToTable("tbl_Territory");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .HasMaxLength(256);

            builder.Property(p => p.CompanyId)
               .HasColumnName("CompanyId")
               .HasMaxLength(38);

            #endregion
        }
    }
}
