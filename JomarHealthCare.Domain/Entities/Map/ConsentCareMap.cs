using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ConsentCareMap : IEntityTypeConfiguration<ConsentCare>
    {
        public void Configure(EntityTypeBuilder<ConsentCare> builder)
        {
            builder.ToTable("tbl_ConsentCare");
            builder.HasKey(k => k.CareId);

            #region Properties

            builder.Property(p => p.CareId)
                .HasColumnName("CareId")
                .IsRequired();

            builder.Property(p => p.PersonalDetailId)
               .HasColumnName("PersonalDetailId")
               .IsRequired();

            builder.Property(p => p.Name)
                .HasColumnName("Name")
                .IsRequired();

            builder.Property(p => p.Signature)
              .HasColumnName("Signature")
              .IsRequired();

            builder.Property(p => p.Date)
             .HasColumnName("Date")
             .IsRequired();

            #endregion
        }
    }
}
