using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class incomeForAllStaffMap : IEntityTypeConfiguration<IncomeForAllStaff>
    {
        public void Configure(EntityTypeBuilder<IncomeForAllStaff> builder)
        {
            builder.ToTable("tbl_IncomeForAllStaff");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Id)
               .HasColumnName("Id")
               .IsRequired();

            builder.Property(p => p.StaffId)
             .HasColumnName("StaffId")
             .IsRequired(false);

            builder.Property(p => p.StartDate)
          .HasColumnName("StartDate")
             .IsRequired();

            builder.Property(p => p.EndDate)
          .HasColumnName("EndDate")
          .IsRequired();
            #endregion

            builder.HasMany<IncomeValue>(p => p.IncomeValue)
               .WithOne(p => p.IncomeForAllStaff)
               .HasForeignKey(p => p.IncomeForAllStaffId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
