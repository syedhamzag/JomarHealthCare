using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class AmountRateTypeMap : IEntityTypeConfiguration<AmountRateType>
    {
        public void Configure(EntityTypeBuilder<AmountRateType> builder)
        {
            builder.ToTable("tbl_AmountRateType");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Id)
               .HasColumnName("Id")
               .IsRequired();

            builder.Property(p => p.Name)
               .HasColumnName("Name")
               .IsRequired();

            builder.Property(p => p.CreatedBy)
             .HasColumnName("CreatedBy")
             .IsRequired(false);
            #endregion
        }
    }
}
