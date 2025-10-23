using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class PlannedDeductionMap : IEntityTypeConfiguration<PlannedDeduction>
    {
        public void Configure(EntityTypeBuilder<PlannedDeduction> builder)
        {
            builder.ToTable("tbl_PlannedDeduction");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Id)
             .HasColumnName("Id")
             .IsRequired();

            builder.Property(p => p.StaffId)
             .HasColumnName("StaffId")
             .IsRequired();

            builder.Property(p => p.DeductionId)
            .HasColumnName("DeductionId")
            .IsRequired();

            builder.Property(p => p.GrossAmount)
           .HasColumnName("GrossAmount")
           .IsRequired();

            builder.Property(p => p.AmountToDeduct)
           .HasColumnName("AmountToDeduct")
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
