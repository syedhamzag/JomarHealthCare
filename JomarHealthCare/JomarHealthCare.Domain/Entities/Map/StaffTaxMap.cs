using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffTaxMap : IEntityTypeConfiguration<StaffTax>
    {
        public void Configure(EntityTypeBuilder<StaffTax> builder)
        {
            builder.ToTable("tbl_StaffTax");
            builder.HasKey(k => k.StaffTaxId);

            #region Properties
            builder.Property(p => p.StaffPersonalInfoId)
              .HasColumnName("StaffPersonalInfoId")
              .IsRequired();

            builder.Property(p => p.Tax)
              .HasColumnName("Tax")
              .IsRequired();

            builder.Property(p => p.NI)
             .HasColumnName("NI")
             .IsRequired();

            builder.Property(p => p.Remarks)
             .HasColumnName("Remarks")
             .IsRequired();

            #endregion

            #region Relationship
            builder.HasOne(p => p.StaffPersonalInfo)
                    .WithMany(m => m.StaffTax)
                    .HasForeignKey(f => f.StaffPersonalInfoId)
                    .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
