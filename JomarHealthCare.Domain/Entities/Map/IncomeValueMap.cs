using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class IncomeValueMap : IEntityTypeConfiguration<IncomeValue>
    {
        public void Configure(EntityTypeBuilder<IncomeValue> builder)
        {
            builder.ToTable("tbl_IncomeValue");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Id)
               .HasColumnName("Id")
               .IsRequired();

            builder.Property(p => p.IncomeForAllStaffId)
             .HasColumnName("IncomeForAllStaffId")
             .IsRequired();

             builder.Property(p => p.IncomeType)
            .HasColumnName("IncomeType")
            .IsRequired();

            #endregion

            builder.HasOne(p => p.IncomeForAllStaff)
             .WithMany(p => p.IncomeValue)
             .HasForeignKey(p => p.IncomeForAllStaffId)
             .IsRequired()
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
