using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class RegisterIncomeMap : IEntityTypeConfiguration<RegisterIncome>
    {
        public void Configure(EntityTypeBuilder<RegisterIncome> builder)
        {
            builder.ToTable("tbl_RegisterIncome");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Id)
               .HasColumnName("Id")
               .IsRequired();

            builder.Property(p => p.IncomeName)
               .HasColumnName("IncomeName")
               .IsRequired();

            builder.Property(p => p.CompanyId)
             .HasColumnName("CompanyId")
             .IsRequired(false);
            #endregion
        }
    }
}
