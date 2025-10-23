using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("tbl_Company");

            builder.HasKey(p => p.CompanyId);

            #region Properties

            builder.Property(p => p.Address)
                 .HasColumnName("Address")
                 .HasMaxLength(255)
                 .IsRequired(false);

            builder.Property(p => p.CompanyId)
                .HasColumnName("CompanyId")
                .IsRequired();

            builder.Property(p => p.CompanyName)
            .HasColumnName("CompanyName")
            .HasMaxLength(255)
            .IsRequired();

            builder.Property(p => p.AdminAdvertisementId)
            .HasColumnName("AdminmessageId")
            .IsRequired(false);

            builder.Property(p => p.AdminAdvertisementId)
           .HasColumnName("AdminAdvertisementId")
           .IsRequired(false);

            builder.Property(p => p.Website)
               .HasColumnName("Website")
               .HasMaxLength(255)
               .IsRequired(false);

            builder.Property(p => p.LogoUrl)
              .HasColumnName("LogoUrl")
              .IsRequired(false);

            builder.Property(p => p.Language)
              .HasColumnName("Language")
              .HasMaxLength(100)
              .IsRequired(false);

            builder.Property(p => p.PostCode)
           .HasColumnName("PostCode")
           .HasMaxLength(100)
           .IsRequired(false);

            builder.Property(p => p.Telephone)
           .HasColumnName("Telephone")
           .HasMaxLength(100)
           .IsRequired(false);

            builder.Property(p => p.Country)
           .HasColumnName("Country")
           .HasMaxLength(100)
           .IsRequired(false);

            builder.Property(p => p.Currency)
           .HasColumnName("Currency")
           .HasMaxLength(100)
           .IsRequired(false);

            builder.Property(p => p.DateFrom)
           .HasColumnName("DateFrom")
           .IsRequired(false);

            builder.Property(p => p.DateTo)
           .HasColumnName("DateTo")
           .IsRequired(false);

            builder.Property(p => p.CurrentCqcRating)
           .HasColumnName("CurrentCqcRating")
           .HasMaxLength(255)
           .IsRequired(false);

            builder.Property(p => p.CityOfOperation)
           .HasColumnName("CityOfOperation")
           .HasMaxLength(255)
           .IsRequired(false);

            builder.Property(p => p.IsTrainingModule)
           .HasColumnName("IsTrainingModule");

            builder.Property(p => p.CompanyCode)
                .HasColumnName("CompanyCode")
                .HasMaxLength(8);
            #endregion
        }
    }
}
