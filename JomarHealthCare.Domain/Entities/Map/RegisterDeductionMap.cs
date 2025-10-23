using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    
    public class RegisterDeductionMap : IEntityTypeConfiguration<RegisterDeduction>
    {
        public void Configure(EntityTypeBuilder<RegisterDeduction> builder)
        {
            builder.ToTable("tbl_RegisterDeduction");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Id)
               .HasColumnName("Id")
               .IsRequired();

            builder.Property(p => p.DeductionName)
               .HasColumnName("DeductionName")
               .IsRequired();

            builder.Property(p => p.CompanyId)
          .HasColumnName("CompanyId")
          .IsRequired(false);

            #endregion
        }
    }
}
