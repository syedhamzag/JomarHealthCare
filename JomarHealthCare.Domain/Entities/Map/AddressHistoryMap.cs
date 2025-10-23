using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    internal class AddressHistoryMap : IEntityTypeConfiguration<AddressHistory>
    {
        public void Configure(EntityTypeBuilder<AddressHistory> builder)
        {
            builder.ToTable("tbl_AddressHistory");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Address)
                .HasColumnName("Address")
                .HasMaxLength(1024);

            builder.Property(p => p.PostCode)
                .HasColumnName("PostCode")
                .HasMaxLength(30);

            builder.Property(p => p.FromDate)
                .HasColumnName("FromDate");

            builder.Property(p => p.ToDate)
                .HasColumnName("ToDate");

            builder.Property(p => p.NoOfLandlord)
                .HasColumnName("NoOfLandlord")
                .HasMaxLength(256);

            builder.Property(p => p.LandLordContactNumber)
                .HasColumnName("LandLordContactNumber")
                .HasMaxLength(50);

            builder.Property(p => p.Remarks)
                .HasColumnName("Remarks")
                .HasMaxLength(1024);

            builder.Property(p => p.StaffId)
                .HasColumnName("StaffId");
            #endregion
        }
    }
}
