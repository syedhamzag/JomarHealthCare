using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class StaffAlertCountMatrixMap : IEntityTypeConfiguration<StaffAlertCountMatrix>
    {
        public void Configure(EntityTypeBuilder<StaffAlertCountMatrix> builder)
        {
            builder.ToTable("tbl_staffalertcountmatrix");
            builder.HasKey(k => k.Id);
            #region Properties

            builder.HasOne(p => p.StaffAlert)
             .WithMany(p => p.StaffAlertCountMatrix)
             .HasForeignKey(p => p.StaffAlertId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.Property(p => p.Missed)
              .HasColumnName("Missed")
              .IsRequired();

            builder.Property(p => p.AboutToExpired)
              .HasColumnName("AboutToExpired")
              .IsRequired();

            builder.Property(p => p.Expired)
              .HasColumnName("Expired")
              .IsRequired();

            builder.Property(p => p.TotalCouts)
              .HasColumnName("TotalCouts")
              .IsRequired();

            builder.Property(p => p.Deleted)
              .HasColumnName("Deleted")
              .IsRequired();
            #endregion
        }
    }
}
