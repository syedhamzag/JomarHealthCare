using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CompanyPincodeMap : IEntityTypeConfiguration<CompanyPincode>
    {
        public void Configure(EntityTypeBuilder<CompanyPincode> builder)
        {
            builder.ToTable("tbl_CompanyPincode");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Pincode)
               .HasColumnName("Pincode")
               .HasMaxLength(10);

            builder.Property(p => p.CreatedBy)
               .HasColumnName("CreatedBy")
               .HasMaxLength(450);
            #endregion
        }
    }
}
