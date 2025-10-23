using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class AdminAdvertisementMap : IEntityTypeConfiguration<AdminAdvertisement>
    {
        public void Configure(EntityTypeBuilder<AdminAdvertisement> builder)
        {
            builder.ToTable("tbl_AdminAdvertisement");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Image)
               .HasColumnName("Image")
               .HasMaxLength(1025)
               .IsRequired(true);

            builder.Property(p => p.IsForAll)
               .HasColumnName("IsForAll")
               .IsRequired();

            builder.Property(p => p.CreatedDate)
               .HasColumnName("CreatedDate")
               .IsRequired();


            #endregion
        }
    }
}
