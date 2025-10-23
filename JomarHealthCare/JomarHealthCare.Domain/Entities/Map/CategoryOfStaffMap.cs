using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CategoryOfStaffMap : IEntityTypeConfiguration<CategoryOfStaff>
    {
        public void Configure(EntityTypeBuilder<CategoryOfStaff> builder)
        {
            builder.ToTable("tbl_CategoryOfStaff");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Id)
               .HasColumnName("Id")
               .IsRequired();

            builder.Property(p => p.CategoryName)
               .HasColumnName("CategoryName")
               .HasMaxLength(256);

            builder.Property(p => p.CompanyId)
             .HasColumnName("CompanyId")
             .HasMaxLength(38);
            #endregion
        }
    }
}
