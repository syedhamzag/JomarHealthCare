using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClassOfStaffMap : IEntityTypeConfiguration<ClassOfStaff>
    {
        public void Configure(EntityTypeBuilder<ClassOfStaff> builder)
        {
            builder.ToTable("tbl_ClassOfStaff");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Id)
               .HasColumnName("Id")
               .IsRequired();

            builder.Property(p => p.ClassName)
               .HasColumnName("ClassName")
               .IsRequired();

            builder.Property(p => p.CompanyId)
             .HasColumnName("CompanyId")
             .HasMaxLength(38);


            #endregion
        }
    }
}
