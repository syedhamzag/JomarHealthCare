using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class DeductionValueMap : IEntityTypeConfiguration<DeductionValue>
    {
        public void Configure(EntityTypeBuilder<DeductionValue> builder)
        {
            builder.ToTable("tbl_DeductionValue");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Id)
               .HasColumnName("Id")
               .IsRequired();

            builder.Property(p => p.DeductionForAllStaffId)
             .HasColumnName("DeductionForAllStaffId")
             .IsRequired();

            builder.Property(p => p.DeductionType)
           .HasColumnName("DeductionType")
           .IsRequired();


            #endregion
        }
    }
}
