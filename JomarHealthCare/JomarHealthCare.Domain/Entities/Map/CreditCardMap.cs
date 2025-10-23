using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class CreditCardMap : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder.ToTable("tbl_CreditCard");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.CardType)
             .HasColumnName("CardType");

            builder.Property(p => p.OtherTypeName)
             .HasColumnName("OtherTypeName")
             .HasMaxLength(255);

            builder.Property(p => p.CardHolderName)
                .HasColumnName("CardHolderName")
                .HasMaxLength(256);

            builder.Property(p => p.CardNumber)
                .HasColumnName("CardNumber")
                .HasMaxLength(50);

            builder.Property(p => p.ExpirationDate)
            .HasColumnName("ExpirationDate")
            .HasMaxLength(10);

            builder.Property(p => p.PostalCode)
            .HasColumnName("PostalCode")
            .HasMaxLength(20);

            builder.Property(p => p.CustomerName)
            .HasColumnName("CustomerName")
            .HasMaxLength(256);

            builder.Property(p => p.CustomerSignature)
            .HasColumnName("CustomerSignature")
            .HasMaxLength(512);

            builder.Property(p => p.SignatureDate)
            .HasColumnName("SignatureDate");
            #endregion


        }
    }
}
