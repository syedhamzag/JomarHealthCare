using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CompanyReceptionMap : IEntityTypeConfiguration<CompanyReception>
    {
        public void Configure(EntityTypeBuilder<CompanyReception> builder)
        {
            builder.ToTable("tbl_CompanyReception");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .HasMaxLength(250);

            builder.Property(p => p.Email)
               .HasColumnName("Email")
               .HasMaxLength(250);

            builder.Property(p => p.logoUrl)
            .HasColumnName("logoUrl")
            .HasMaxLength(1052);

            builder.Property(p => p.Notes)
            .HasMaxLength(1052);

            #endregion
        }
    }
}
