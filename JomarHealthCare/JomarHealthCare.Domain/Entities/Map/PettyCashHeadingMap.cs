using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PettyCashHeadingMap : IEntityTypeConfiguration<PettyCashHeading>
    {
        public void Configure(EntityTypeBuilder<PettyCashHeading> builder)
        {
            builder.ToTable("tbl_PettyCashHeading");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Name)
             .HasColumnName("Name")
             .HasMaxLength(250);

            builder.Property(p => p.IsMethod)
             .HasColumnName("IsMethod");

            builder.Property(p => p.CompanyId)
             .HasColumnName("CompanyId")
             .HasMaxLength(450);
            #endregion
        }
    }
}
