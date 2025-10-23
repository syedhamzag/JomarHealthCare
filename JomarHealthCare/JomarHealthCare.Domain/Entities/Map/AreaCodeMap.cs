using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class AreaCodeMap : IEntityTypeConfiguration<AreaCode>
    {
        public void Configure(EntityTypeBuilder<AreaCode> builder)
        {
            builder.ToTable("tbl_AreaCode");
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
