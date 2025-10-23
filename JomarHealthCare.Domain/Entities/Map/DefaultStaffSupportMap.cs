using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class DefaultStaffSupportMap : IEntityTypeConfiguration<DefaultStaffSupport>
    {
        public void Configure(EntityTypeBuilder<DefaultStaffSupport> builder)
        {
            builder.ToTable("tbl_DefaultStaffSupport");
            builder.HasKey(k => k.Id);

            #region Properties

            builder.Property(p => p.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(p => p.StaffId)
               .HasColumnName("StaffId")
               .IsRequired(true);

            builder.Property(p => p.SupportType)
                .HasColumnName("SupportType")
                .IsRequired(true);

            #endregion
        }
    }

}
