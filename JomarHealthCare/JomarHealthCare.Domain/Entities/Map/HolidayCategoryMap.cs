using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class HolidayCategoryMap : IEntityTypeConfiguration<HolidayCategory>
    {
        public void Configure(EntityTypeBuilder<HolidayCategory> builder)
        {
            builder.ToTable("tbl_HolidayCategory");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Name)
             .HasColumnName("Name")
             .HasMaxLength(256);

            builder.Property(p => p.NoOfDays)
             .HasColumnName("NoOfDays");

            builder.Property(p => p.CompanyId)
                .HasColumnName("CompanyId")
                .HasMaxLength(450);
            #endregion

        }
    }
}
