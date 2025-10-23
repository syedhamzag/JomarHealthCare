using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PlannedIncomeMap : IEntityTypeConfiguration<PlannedIncome>
    {
        public void Configure(EntityTypeBuilder<PlannedIncome> builder)
        {
            builder.ToTable("tbl_PlannedIncome");
            builder.HasKey(k => k.Id);

            #region Properties
              builder.Property(p => p.Id)
               .HasColumnName("Id")
               .IsRequired();

              builder.Property(p => p.StaffId)
               .HasColumnName("StaffId")
               .IsRequired();

              builder.Property(p => p.IncomeId)
              .HasColumnName("IncomeId")
              .IsRequired();

              builder.Property(p => p.GrossAmount)
             .HasColumnName("GrossAmount")
             .IsRequired();

              builder.Property(p => p.AmountToAdd)
             .HasColumnName("AmountToAdd")
             .IsRequired(false);

              builder.Property(p => p.PercentageOfGross)
              .HasColumnName("PercentageOfGross")
              .IsRequired(false);

              builder.Property(p => p.FromDate)
              .HasColumnName("FromDate")
              .IsRequired();

            builder.Property(p => p.ToDate)
             .HasColumnName("ToDate")
             .IsRequired();

            #endregion
        }
    }
}
